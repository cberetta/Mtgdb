using System.Collections.Generic;

namespace Mtgdb
{
	public static class Sequence
	{
		public static IEnumerable<T> From<T>(T value)
		{
			yield return value;
		}

		public static IEnumerable<T> From<T>(T value1, T value2)
		{
			yield return value1;
			yield return value2;
		}

		public static IEnumerable<T> From<T>(T value1, T value2, T value3)
		{
			yield return value1;
			yield return value2;
			yield return value3;
		}
	}
}