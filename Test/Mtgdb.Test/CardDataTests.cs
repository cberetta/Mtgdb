using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using FluentAssertions;
using Mtgdb.Data;
using NUnit.Framework;

namespace Mtgdb.Test
{
	[TestFixture]
	public class CardDataTests : TestsBase
	{
		[OneTimeSetUp]
		public void OneTimeSetup()
		{
			LoadCards();
		}

		[SetUp]
		public void Setup()
		{
			Formatter.CustomLayout = new []
			{
				new[] { nameof(Card.SetCode), nameof(Card.Number), nameof(Card.TypeEn), nameof(Card.MultiverseId) }
			};
		}

		[TearDown]
		public void Teardown()
		{
			Formatter.CustomLayout = null;
		}

		[Test]
		public void Id_is_unique()
		{
			Repo.Cards.Should().OnlyHaveUniqueItems(card => card.Id);
		}

		[Test]
		public void Token_ids_do_not_intersect_with_card_ids()
		{
			var cardIds = Repo.Cards.Where(_ => !_.IsToken).Select(_ => _.Id);
			var tokenIds = Repo.Cards.Where(_ => _.IsToken).Select(_ => _.Id);
			cardIds.Should().NotIntersectWith(tokenIds);
		}

		[Test]
		public void Price_patch_does_not_lose_information()
		{
			foreach (var card in Repo.Cards)
			{
				if ((card.OriginalPrices?.Paper?.Count ?? 0) == 0)
					continue;

				Assert.That(card.OriginalPrices.Paper.Count <= card.Prices.Paper.Count);
			}
		}

		[Test]
		public void Price_dates_are_correct()
		{
			foreach (var card in Repo.Cards)
			{
				if ((card.Prices?.Paper?.Count ?? 0) == 0)
					continue;

				for (var i = 0; i < card.Prices.Paper.Count; i++)
				{
					var date = card.Prices.Paper[i].Key;

					Assert.That(date, Is.Not.Null);
					Assert.That(date, Is.Not.Empty);
					Assert.That(date, Does.Match(@"^\d{4}-\d{2}-\d{2}$"));

					if (i > 0)
					{
						var prevDate = card.Prices.Paper[i - 1].Key;
						Assert.That(date, Is.GreaterThan(prevDate).Using<string>(StringComparer.Ordinal));
					}
				}
			}
		}

		[Test]
		public void Tokens_have_exclusive_type_or_name()
		{
			foreach (Set set in Repo.SetsByCode.Values)
			{
				set.Tokens.Should().NotContain(card => !isToken(card));
				set.ActualCards.Should().NotContain(card => isToken(card));
			}
		}

		[Test]
		public void Tokens_have_IsToken_flag_set()
		{
			foreach (Set set in Repo.SetsByCode.Values)
			{
				set.Tokens.Should().NotContain(card => !card.IsToken);
				set.ActualCards.Should().NotContain(card => card.IsToken);
			}
		}

		[Test]
		public void Tokens_in_set_are_in_separate_map()
		{
			foreach (Set set in Repo.SetsByCode.Values)
			{
				foreach (var (_, cards) in set.ActualCardsByName)
				{
					cards.Should().NotContain(card => card.IsToken);
					foreach (var card in cards)
						card.Namesakes.Should().NotContain(_ => _.IsToken);
				}

				foreach (var (_, tokens) in set.TokensByName)
				{
					tokens.Should().NotContain(token => !token.IsToken);
					foreach (var token in tokens)
						token.Namesakes.Should().NotContain(_ => !_.IsToken);
				}
			}
		}

		[Test]
		public void Namesakes_within_set_have_same_printings_list()
		{
			foreach (Set set in Repo.SetsByCode.Values)
			{
				foreach (var (_, cards) in set.ActualCardsByName)
				foreach (var card in cards)
					card.Printings.Should().BeEquivalentTo(cards[0].Printings);

				foreach (var (_, tokens) in set.TokensByName)
				foreach (var token in tokens)
					token.Printings.Should().BeEquivalentTo(tokens[0].Printings);
			}
		}

		[Test]
		public void Printings_point_to_sets_with_namesakes()
		{
			foreach (Set set in Repo.SetsByCode.Values)
			{
				foreach (var (_, cards) in set.ActualCardsByName)
				{
					var card = cards[0];
					foreach (string setcode in card.Printings)
						Repo.SetsByCode[setcode].ActualCardsByName[card.NameNormalized].Should().NotBeEmpty();
				}

				foreach (var (_, tokens) in set.TokensByName)
				{
					var token = tokens[0];
					foreach (string setcode in token.Printings)
						Repo.SetsByCode[setcode].TokensByName[token.NameNormalized].Should().NotBeEmpty();
				}
			}
		}

		[Test]
		public void Plus_minus_are_followed_by_letter()
		{
			var regex = new Regex(@"[+\-]\p{L}");
			Repo.Cards.Select(_ => _.TextEn).Where(F.IsNotNull)
				.Should().NotContain(_ => regex.IsMatch(_));
		}

		private static bool isToken(Card c) =>
			_tokenNames.Contains(c.NameEn) || _tokenTypes.Overlaps(c.TypesArr);

		private static readonly HashSet<string> _tokenTypes =
			new HashSet<string>(Str.Comparer)
			{
				"Token", "Emblem", "Card",
				// "Elite",
			};

		private static readonly HashSet<string> _tokenNames =
			new HashSet<string>(Str.Comparer)
			{
				"Morph", "Manifest",
				// "Punchcard",
			};
	}
}
