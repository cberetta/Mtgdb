﻿using System.Windows.Forms;

namespace Mtgdb.Gui
{
	partial class FormRoot
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoot));
			this._tabs = new Mtgdb.Controls.TabHeaderControl();
			this._buttonUndo = new Mtgdb.Controls.CustomCheckBox();
			this._buttonRedo = new Mtgdb.Controls.CustomCheckBox();
			this._buttonDonate = new Mtgdb.Controls.CustomCheckBox();
			this._buttonUpdate = new Mtgdb.Controls.CustomCheckBox();
			this._buttonLanguage = new Mtgdb.Controls.CustomCheckBox();
			this._buttonConfig = new Mtgdb.Controls.CustomCheckBox();
			this._buttonHelp = new Mtgdb.Controls.CustomCheckBox();
			this._buttonClear = new Mtgdb.Controls.CustomCheckBox();
			this._buttonPrint = new Mtgdb.Controls.CustomCheckBox();
			this._buttonStat = new Mtgdb.Controls.CustomCheckBox();
			this._buttonSaveDeck = new Mtgdb.Controls.CustomCheckBox();
			this._buttonOpenDeck = new Mtgdb.Controls.CustomCheckBox();
			this._buttonTooltips = new Mtgdb.Controls.CustomCheckBox();
			this._menuOpen = new Mtgdb.Controls.BorderedTableLayoutPanel();
			this._buttonImportExportToMtgArena = new Mtgdb.Controls.CustomCheckBox();
			this._buttonMenuSaveCollection = new Mtgdb.Controls.CustomCheckBox();
			this._labelMagarena = new System.Windows.Forms.Label();
			this._buttonMenuSaveDeck = new Mtgdb.Controls.CustomCheckBox();
			this._labelDotP2 = new System.Windows.Forms.Label();
			this._buttonMenuOpenCollection = new Mtgdb.Controls.CustomCheckBox();
			this._labelMtgo = new System.Windows.Forms.Label();
			this._buttonMenuOpenDeck = new Mtgdb.Controls.CustomCheckBox();
			this._buttonVisitMtgo = new Mtgdb.Controls.CustomCheckBox();
			this._buttonVisitCockatrice = new Mtgdb.Controls.CustomCheckBox();
			this._buttonVisitDotP2014 = new Mtgdb.Controls.CustomCheckBox();
			this._labelFormats = new System.Windows.Forms.Label();
			this._buttonVisitXMage = new Mtgdb.Controls.CustomCheckBox();
			this._buttonVisitMagarena = new Mtgdb.Controls.CustomCheckBox();
			this._buttonVisitDeckedBuilder = new Mtgdb.Controls.CustomCheckBox();
			this._buttonVisitForge = new Mtgdb.Controls.CustomCheckBox();
			this._buttonVisitMtgArena = new Mtgdb.Controls.CustomCheckBox();
			this._buttonImportMtgArenaCollection = new Mtgdb.Controls.CustomCheckBox();
			this._menuLanguage = new Mtgdb.Controls.BorderedTableLayoutPanel();
			this._buttonPT = new Mtgdb.Controls.CustomCheckBox();
			this._buttonDE = new Mtgdb.Controls.CustomCheckBox();
			this._buttonCN = new Mtgdb.Controls.CustomCheckBox();
			this._buttonEN = new Mtgdb.Controls.CustomCheckBox();
			this._buttonTW = new Mtgdb.Controls.CustomCheckBox();
			this._buttonIT = new Mtgdb.Controls.CustomCheckBox();
			this._buttonJP = new Mtgdb.Controls.CustomCheckBox();
			this._buttonKR = new Mtgdb.Controls.CustomCheckBox();
			this._buttonFR = new Mtgdb.Controls.CustomCheckBox();
			this._buttonES = new Mtgdb.Controls.CustomCheckBox();
			this._buttonRU = new Mtgdb.Controls.CustomCheckBox();
			this._menuDonate = new Mtgdb.Controls.BorderedTableLayoutPanel();
			this._buttonMenuDonateYandexMoney = new Mtgdb.Controls.CustomCheckBox();
			this._panelAva = new Mtgdb.Controls.BorderedPanel();
			this._buttonMenuDonatePayPal = new Mtgdb.Controls.CustomCheckBox();
			this._labelDonate = new System.Windows.Forms.Label();
			this._buttonPaste = new Mtgdb.Controls.CustomCheckBox();
			this._menuPaste = new Mtgdb.Controls.BorderedTableLayoutPanel();
			this._buttonMenuCopyCollection = new Mtgdb.Controls.CustomCheckBox();
			this._buttonMenuCopyDeck = new Mtgdb.Controls.CustomCheckBox();
			this._buttonMenuPasteCollectionAppend = new Mtgdb.Controls.CustomCheckBox();
			this._buttonMenuPasteCollection = new Mtgdb.Controls.CustomCheckBox();
			this._labelPasteInfo = new System.Windows.Forms.Label();
			this._buttonMenuPasteDeck = new Mtgdb.Controls.CustomCheckBox();
			this._buttonMenuPasteDeckAppend = new Mtgdb.Controls.CustomCheckBox();
			this._layoutTitle = new Mtgdb.Controls.BorderedTableLayoutPanel();
			this._flowTitleRight = new Mtgdb.Controls.BorderedFlowLayoutPanel();
			this._buttonShowFilterPanels = new Mtgdb.Controls.CustomCheckBox();
			this._buttonColorScheme = new Mtgdb.Controls.CustomCheckBox();
			this._buttonSupport = new Mtgdb.Controls.CustomCheckBox();
			this._flowTitleLeft = new Mtgdb.Controls.BorderedFlowLayoutPanel();
			this._buttonOpenWindow = new Mtgdb.Controls.CustomCheckBox();
			this._menuColors = new System.Windows.Forms.ContextMenuStrip(this.components);
			this._menuItemEditColorScheme = new System.Windows.Forms.ToolStripMenuItem();
			this._menuConfig = new Mtgdb.Controls.BorderedTableLayoutPanel();
			this._menuUiUndoDepth = new System.Windows.Forms.ComboBox();
			this._menuUiImagesCacheCapacity = new System.Windows.Forms.ComboBox();
			this._labelUiUndoDepth = new System.Windows.Forms.Label();
			this._labelUiImageCacheCapacity = new System.Windows.Forms.Label();
			this._labelUiSuggestDownloadMissingImages = new System.Windows.Forms.Label();
			this._labelUiUseSmallImagesHint = new System.Windows.Forms.Label();
			this._labelUiScale = new System.Windows.Forms.Label();
			this._menuUiScale = new System.Windows.Forms.ComboBox();
			this._buttonMenuEditConfig = new Mtgdb.Controls.CustomCheckBox();
			this._labelUiUseSmallImages = new System.Windows.Forms.Label();
			this._menuUiSmallImageQuality = new System.Windows.Forms.ComboBox();
			this._menuUiSuggestDownloadMissingImages = new System.Windows.Forms.ComboBox();
			this._panelCaption.SuspendLayout();
			this._menuOpen.SuspendLayout();
			this._menuLanguage.SuspendLayout();
			this._menuDonate.SuspendLayout();
			this._menuPaste.SuspendLayout();
			this._layoutTitle.SuspendLayout();
			this._flowTitleRight.SuspendLayout();
			this._flowTitleLeft.SuspendLayout();
			this._menuColors.SuspendLayout();
			this._menuConfig.SuspendLayout();
			this.SuspendLayout();
			// 
			// _panelClient
			// 
			this._panelClient.Location = new System.Drawing.Point(6, 37);
			this._panelClient.Size = new System.Drawing.Size(1012, 757);
			this._panelClient.TabIndex = 1;
			// 
			// _panelCaption
			// 
			this._panelCaption.Controls.Add(this._layoutTitle);
			this._panelCaption.Size = new System.Drawing.Size(907, 31);
			// 
			// _tabs
			// 
			this._tabs.AddButtonSlopeSize = new System.Drawing.Size(9, 17);
			this._tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._tabs.DrawBottomBorder = true;
			this._tabs.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._tabs.Location = new System.Drawing.Point(108, 4);
			this._tabs.Margin = new System.Windows.Forms.Padding(0);
			this._tabs.Name = "_tabs";
			this._tabs.PaintBackground = false;
			this._tabs.Size = new System.Drawing.Size(42, 27);
			this._tabs.SlopeSize = new System.Drawing.Size(15, 27);
			this._tabs.TabIndex = 2;
			this._tabs.TabStop = false;
			// 
			// _buttonUndo
			// 
			this._buttonUndo.AutoCheck = false;
			this._buttonUndo.BackColor = System.Drawing.Color.Transparent;
			this._buttonUndo.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonUndo.Image = global::Mtgdb.Gui.Properties.Resources.undo_16;
			this._buttonUndo.Location = new System.Drawing.Point(0, 3);
			this._buttonUndo.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this._buttonUndo.Name = "_buttonUndo";
			this._buttonUndo.Padding = new System.Windows.Forms.Padding(4);
			this._buttonUndo.Size = new System.Drawing.Size(32, 24);
			this._buttonUndo.TabIndex = 0;
			// 
			// _buttonRedo
			// 
			this._buttonRedo.AutoCheck = false;
			this._buttonRedo.BackColor = System.Drawing.Color.Transparent;
			this._buttonRedo.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonRedo.Image = global::Mtgdb.Gui.Properties.Resources.redo_16;
			this._buttonRedo.Location = new System.Drawing.Point(32, 3);
			this._buttonRedo.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this._buttonRedo.Name = "_buttonRedo";
			this._buttonRedo.Padding = new System.Windows.Forms.Padding(4);
			this._buttonRedo.Size = new System.Drawing.Size(32, 24);
			this._buttonRedo.TabIndex = 1;
			// 
			// _buttonDonate
			// 
			this._buttonDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonDonate.AutoCheck = false;
			this._buttonDonate.BackColor = System.Drawing.Color.Transparent;
			this._buttonDonate.ForeColor = System.Drawing.SystemColors.WindowText;
			this._buttonDonate.Location = new System.Drawing.Point(622, 3);
			this._buttonDonate.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this._buttonDonate.Name = "_buttonDonate";
			this._buttonDonate.Padding = new System.Windows.Forms.Padding(4);
			this._buttonDonate.Size = new System.Drawing.Size(50, 24);
			this._buttonDonate.TabIndex = 14;
			this._buttonDonate.Text = "Donate";
			// 
			// _buttonUpdate
			// 
			this._buttonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonUpdate.AutoCheck = false;
			this._buttonUpdate.BackColor = System.Drawing.Color.Transparent;
			this._buttonUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonUpdate.Image = global::Mtgdb.Gui.Properties.Resources.update_40;
			this._buttonUpdate.Location = new System.Drawing.Point(476, 3);
			this._buttonUpdate.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this._buttonUpdate.Name = "_buttonUpdate";
			this._buttonUpdate.Padding = new System.Windows.Forms.Padding(4);
			this._buttonUpdate.Size = new System.Drawing.Size(32, 24);
			this._buttonUpdate.TabIndex = 12;
			// 
			// _buttonLanguage
			// 
			this._buttonLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonLanguage.BackColor = System.Drawing.SystemColors.Window;
			this._buttonLanguage.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonLanguage.HighlightCheckedOpacity = 24;
			this._buttonLanguage.HighlightMouseOverOpacity = 24;
			this._buttonLanguage.Image = global::Mtgdb.Gui.Properties.Resources.en;
			this._buttonLanguage.Location = new System.Drawing.Point(371, 3);
			this._buttonLanguage.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this._buttonLanguage.Name = "_buttonLanguage";
			this._buttonLanguage.Padding = new System.Windows.Forms.Padding(4);
			this._buttonLanguage.Size = new System.Drawing.Size(58, 22);
			this._buttonLanguage.TabIndex = 10;
			this._buttonLanguage.Text = "EN";
			// 
			// _buttonConfig
			// 
			this._buttonConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonConfig.AutoCheck = false;
			this._buttonConfig.BackColor = System.Drawing.Color.Transparent;
			this._buttonConfig.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonConfig.Image = global::Mtgdb.Gui.Properties.Resources.properties_16;
			this._buttonConfig.Location = new System.Drawing.Point(304, 3);
			this._buttonConfig.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this._buttonConfig.Name = "_buttonConfig";
			this._buttonConfig.Padding = new System.Windows.Forms.Padding(4);
			this._buttonConfig.Size = new System.Drawing.Size(32, 24);
			this._buttonConfig.TabIndex = 8;
			// 
			// _buttonHelp
			// 
			this._buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonHelp.AutoCheck = false;
			this._buttonHelp.BackColor = System.Drawing.Color.Transparent;
			this._buttonHelp.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonHelp.Image = global::Mtgdb.Gui.Properties.Resources.index_16;
			this._buttonHelp.Location = new System.Drawing.Point(444, 3);
			this._buttonHelp.Margin = new System.Windows.Forms.Padding(12, 3, 0, 0);
			this._buttonHelp.Name = "_buttonHelp";
			this._buttonHelp.Padding = new System.Windows.Forms.Padding(4);
			this._buttonHelp.Size = new System.Drawing.Size(32, 24);
			this._buttonHelp.TabIndex = 11;
			// 
			// _buttonClear
			// 
			this._buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonClear.AutoCheck = false;
			this._buttonClear.BackColor = System.Drawing.Color.Transparent;
			this._buttonClear.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonClear.Image = global::Mtgdb.Gui.Properties.Resources.trash_16;
			this._buttonClear.Location = new System.Drawing.Point(120, 3);
			this._buttonClear.Margin = new System.Windows.Forms.Padding(12, 3, 12, 0);
			this._buttonClear.Name = "_buttonClear";
			this._buttonClear.Padding = new System.Windows.Forms.Padding(4);
			this._buttonClear.Size = new System.Drawing.Size(32, 24);
			this._buttonClear.TabIndex = 3;
			// 
			// _buttonPrint
			// 
			this._buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonPrint.AutoCheck = false;
			this._buttonPrint.BackColor = System.Drawing.Color.Transparent;
			this._buttonPrint.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonPrint.Image = global::Mtgdb.Gui.Properties.Resources.print_16;
			this._buttonPrint.Location = new System.Drawing.Point(164, 3);
			this._buttonPrint.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this._buttonPrint.Name = "_buttonPrint";
			this._buttonPrint.Padding = new System.Windows.Forms.Padding(4);
			this._buttonPrint.Size = new System.Drawing.Size(32, 24);
			this._buttonPrint.TabIndex = 4;
			// 
			// _buttonStat
			// 
			this._buttonStat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonStat.AutoCheck = false;
			this._buttonStat.BackColor = System.Drawing.Color.Transparent;
			this._buttonStat.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonStat.Image = global::Mtgdb.Gui.Properties.Resources.chart_16;
			this._buttonStat.Location = new System.Drawing.Point(196, 3);
			this._buttonStat.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this._buttonStat.Name = "_buttonStat";
			this._buttonStat.Padding = new System.Windows.Forms.Padding(4);
			this._buttonStat.Size = new System.Drawing.Size(32, 24);
			this._buttonStat.TabIndex = 5;
			// 
			// _buttonSaveDeck
			// 
			this._buttonSaveDeck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonSaveDeck.AutoCheck = false;
			this._buttonSaveDeck.BackColor = System.Drawing.Color.Transparent;
			this._buttonSaveDeck.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonSaveDeck.Image = global::Mtgdb.Gui.Properties.Resources.save_16;
			this._buttonSaveDeck.Location = new System.Drawing.Point(76, 3);
			this._buttonSaveDeck.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this._buttonSaveDeck.Name = "_buttonSaveDeck";
			this._buttonSaveDeck.Padding = new System.Windows.Forms.Padding(4);
			this._buttonSaveDeck.Size = new System.Drawing.Size(32, 24);
			this._buttonSaveDeck.TabIndex = 2;
			// 
			// _buttonOpenDeck
			// 
			this._buttonOpenDeck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonOpenDeck.AutoCheck = false;
			this._buttonOpenDeck.BackColor = System.Drawing.Color.Transparent;
			this._buttonOpenDeck.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonOpenDeck.Image = global::Mtgdb.Gui.Properties.Resources.open_16;
			this._buttonOpenDeck.Location = new System.Drawing.Point(44, 3);
			this._buttonOpenDeck.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this._buttonOpenDeck.Name = "_buttonOpenDeck";
			this._buttonOpenDeck.Padding = new System.Windows.Forms.Padding(4);
			this._buttonOpenDeck.Size = new System.Drawing.Size(32, 24);
			this._buttonOpenDeck.TabIndex = 1;
			// 
			// _buttonTooltips
			// 
			this._buttonTooltips.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonTooltips.BackColor = System.Drawing.Color.Transparent;
			this._buttonTooltips.Checked = true;
			this._buttonTooltips.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonTooltips.Image = global::Mtgdb.Gui.Properties.Resources.tooltip_16;
			this._buttonTooltips.Location = new System.Drawing.Point(240, 3);
			this._buttonTooltips.Margin = new System.Windows.Forms.Padding(12, 3, 0, 0);
			this._buttonTooltips.Name = "_buttonTooltips";
			this._buttonTooltips.Padding = new System.Windows.Forms.Padding(4);
			this._buttonTooltips.Size = new System.Drawing.Size(32, 24);
			this._buttonTooltips.TabIndex = 6;
			// 
			// _menuOpen
			// 
			this._menuOpen.AutoSize = true;
			this._menuOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._menuOpen.BackColor = System.Drawing.SystemColors.Window;
			this._menuOpen.ColumnCount = 4;
			this._menuOpen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._menuOpen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._menuOpen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._menuOpen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._menuOpen.Controls.Add(this._buttonImportExportToMtgArena, 1, 6);
			this._menuOpen.Controls.Add(this._buttonMenuSaveCollection, 0, 3);
			this._menuOpen.Controls.Add(this._labelMagarena, 1, 10);
			this._menuOpen.Controls.Add(this._buttonMenuSaveDeck, 0, 2);
			this._menuOpen.Controls.Add(this._labelDotP2, 1, 9);
			this._menuOpen.Controls.Add(this._buttonMenuOpenCollection, 0, 1);
			this._menuOpen.Controls.Add(this._labelMtgo, 1, 8);
			this._menuOpen.Controls.Add(this._buttonMenuOpenDeck, 0, 0);
			this._menuOpen.Controls.Add(this._buttonVisitMtgo, 0, 8);
			this._menuOpen.Controls.Add(this._buttonVisitCockatrice, 0, 10);
			this._menuOpen.Controls.Add(this._buttonVisitDotP2014, 0, 9);
			this._menuOpen.Controls.Add(this._labelFormats, 0, 4);
			this._menuOpen.Controls.Add(this._buttonVisitXMage, 1, 5);
			this._menuOpen.Controls.Add(this._buttonVisitMagarena, 2, 5);
			this._menuOpen.Controls.Add(this._buttonVisitDeckedBuilder, 3, 5);
			this._menuOpen.Controls.Add(this._buttonVisitForge, 0, 5);
			this._menuOpen.Controls.Add(this._buttonVisitMtgArena, 0, 6);
			this._menuOpen.Controls.Add(this._buttonImportMtgArenaCollection, 1, 7);
			this._menuOpen.Location = new System.Drawing.Point(349, 269);
			this._menuOpen.Margin = new System.Windows.Forms.Padding(1);
			this._menuOpen.Name = "_menuOpen";
			this._menuOpen.RowCount = 11;
			this._menuOpen.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuOpen.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuOpen.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuOpen.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuOpen.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuOpen.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuOpen.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuOpen.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuOpen.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuOpen.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuOpen.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuOpen.Size = new System.Drawing.Size(273, 521);
			this._menuOpen.TabIndex = 4;
			this._menuOpen.Visible = false;
			this._menuOpen.VisibleBorders = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// _buttonImportExportToMtgArena
			// 
			this._buttonImportExportToMtgArena.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonImportExportToMtgArena.AutoCheck = false;
			this._buttonImportExportToMtgArena.BackColor = System.Drawing.Color.Transparent;
			this._menuOpen.SetColumnSpan(this._buttonImportExportToMtgArena, 3);
			this._buttonImportExportToMtgArena.Cursor = System.Windows.Forms.Cursors.Hand;
			this._buttonImportExportToMtgArena.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._buttonImportExportToMtgArena.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonImportExportToMtgArena.Image = global::Mtgdb.Gui.Properties.Resources.paste_32;
			this._buttonImportExportToMtgArena.Location = new System.Drawing.Point(81, 238);
			this._buttonImportExportToMtgArena.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
			this._buttonImportExportToMtgArena.Name = "_buttonImportExportToMtgArena";
			this._buttonImportExportToMtgArena.Padding = new System.Windows.Forms.Padding(4);
			this._buttonImportExportToMtgArena.Size = new System.Drawing.Size(189, 32);
			this._buttonImportExportToMtgArena.TabIndex = 9;
			this._buttonImportExportToMtgArena.Text = "Export deck to MTGArena";
			this._buttonImportExportToMtgArena.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this._buttonImportExportToMtgArena.VisibleAllBorders = true;
			this._buttonImportExportToMtgArena.VisibleBorders = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// _buttonMenuSaveCollection
			// 
			this._buttonMenuSaveCollection.AutoCheck = false;
			this._buttonMenuSaveCollection.BackColor = System.Drawing.Color.Transparent;
			this._menuOpen.SetColumnSpan(this._buttonMenuSaveCollection, 4);
			this._buttonMenuSaveCollection.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonMenuSaveCollection.Image = global::Mtgdb.Gui.Properties.Resources.box_48;
			this._buttonMenuSaveCollection.Location = new System.Drawing.Point(2, 110);
			this._buttonMenuSaveCollection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
			this._buttonMenuSaveCollection.Name = "_buttonMenuSaveCollection";
			this._buttonMenuSaveCollection.Padding = new System.Windows.Forms.Padding(4);
			this._buttonMenuSaveCollection.Size = new System.Drawing.Size(268, 34);
			this._buttonMenuSaveCollection.TabIndex = 3;
			this._buttonMenuSaveCollection.Text = "Save collection to file: Ctrl+Alt+S";
			this._buttonMenuSaveCollection.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			// 
			// _labelMagarena
			// 
			this._menuOpen.SetColumnSpan(this._labelMagarena, 3);
			this._labelMagarena.Location = new System.Drawing.Point(81, 464);
			this._labelMagarena.Margin = new System.Windows.Forms.Padding(3);
			this._labelMagarena.Name = "_labelMagarena";
			this._labelMagarena.Size = new System.Drawing.Size(189, 54);
			this._labelMagarena.TabIndex = 17;
			this._labelMagarena.Text = "* Supports Magarena format";
			this._labelMagarena.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// _buttonMenuSaveDeck
			// 
			this._buttonMenuSaveDeck.AutoCheck = false;
			this._buttonMenuSaveDeck.BackColor = System.Drawing.Color.Transparent;
			this._menuOpen.SetColumnSpan(this._buttonMenuSaveDeck, 4);
			this._buttonMenuSaveDeck.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonMenuSaveDeck.Image = global::Mtgdb.Gui.Properties.Resources.deck_48;
			this._buttonMenuSaveDeck.Location = new System.Drawing.Point(2, 74);
			this._buttonMenuSaveDeck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
			this._buttonMenuSaveDeck.Name = "_buttonMenuSaveDeck";
			this._buttonMenuSaveDeck.Padding = new System.Windows.Forms.Padding(4);
			this._buttonMenuSaveDeck.Size = new System.Drawing.Size(268, 34);
			this._buttonMenuSaveDeck.TabIndex = 2;
			this._buttonMenuSaveDeck.Text = "Save deck to file: Ctrl+S";
			this._buttonMenuSaveDeck.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			// 
			// _labelDotP2
			// 
			this._menuOpen.SetColumnSpan(this._labelDotP2, 3);
			this._labelDotP2.Location = new System.Drawing.Point(81, 386);
			this._labelDotP2.Margin = new System.Windows.Forms.Padding(3);
			this._labelDotP2.Name = "_labelDotP2";
			this._labelDotP2.Size = new System.Drawing.Size(189, 72);
			this._labelDotP2.TabIndex = 16;
			this._labelDotP2.Text = "* Modified version supports Forge format";
			this._labelDotP2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// _buttonMenuOpenCollection
			// 
			this._buttonMenuOpenCollection.AutoCheck = false;
			this._buttonMenuOpenCollection.BackColor = System.Drawing.Color.Transparent;
			this._menuOpen.SetColumnSpan(this._buttonMenuOpenCollection, 4);
			this._buttonMenuOpenCollection.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonMenuOpenCollection.Image = global::Mtgdb.Gui.Properties.Resources.box_48;
			this._buttonMenuOpenCollection.Location = new System.Drawing.Point(2, 38);
			this._buttonMenuOpenCollection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
			this._buttonMenuOpenCollection.Name = "_buttonMenuOpenCollection";
			this._buttonMenuOpenCollection.Padding = new System.Windows.Forms.Padding(4);
			this._buttonMenuOpenCollection.Size = new System.Drawing.Size(268, 34);
			this._buttonMenuOpenCollection.TabIndex = 1;
			this._buttonMenuOpenCollection.Text = "Load collection from file: Ctrl+Alt+O";
			this._buttonMenuOpenCollection.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			// 
			// _labelMtgo
			// 
			this._menuOpen.SetColumnSpan(this._labelMtgo, 3);
			this._labelMtgo.Location = new System.Drawing.Point(81, 308);
			this._labelMtgo.Margin = new System.Windows.Forms.Padding(3);
			this._labelMtgo.Name = "_labelMtgo";
			this._labelMtgo.Size = new System.Drawing.Size(189, 72);
			this._labelMtgo.TabIndex = 15;
			this._labelMtgo.Text = "* MTGO .txt format is supported in many websites including \r\n - magic.wizards.com" +
    "\r\n - www.mtggoldfish.com";
			this._labelMtgo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// _buttonMenuOpenDeck
			// 
			this._buttonMenuOpenDeck.AutoCheck = false;
			this._buttonMenuOpenDeck.BackColor = System.Drawing.Color.Transparent;
			this._menuOpen.SetColumnSpan(this._buttonMenuOpenDeck, 4);
			this._buttonMenuOpenDeck.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonMenuOpenDeck.Image = global::Mtgdb.Gui.Properties.Resources.deck_48;
			this._buttonMenuOpenDeck.Location = new System.Drawing.Point(2, 2);
			this._buttonMenuOpenDeck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
			this._buttonMenuOpenDeck.Name = "_buttonMenuOpenDeck";
			this._buttonMenuOpenDeck.Padding = new System.Windows.Forms.Padding(4);
			this._buttonMenuOpenDeck.Size = new System.Drawing.Size(268, 34);
			this._buttonMenuOpenDeck.TabIndex = 0;
			this._buttonMenuOpenDeck.Text = "Load deck(s) from file(s): Ctrl+O";
			this._buttonMenuOpenDeck.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			// 
			// _buttonVisitMtgo
			// 
			this._buttonVisitMtgo.AutoCheck = false;
			this._buttonVisitMtgo.BackColor = System.Drawing.Color.Transparent;
			this._buttonVisitMtgo.Cursor = System.Windows.Forms.Cursors.Hand;
			this._buttonVisitMtgo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._buttonVisitMtgo.ForeColor = System.Drawing.SystemColors.HotTrack;
			this._buttonVisitMtgo.Image = global::Mtgdb.Gui.Properties.Resources.mtgo_32;
			this._buttonVisitMtgo.Location = new System.Drawing.Point(3, 308);
			this._buttonVisitMtgo.Name = "_buttonVisitMtgo";
			this._buttonVisitMtgo.Padding = new System.Windows.Forms.Padding(4);
			this._buttonVisitMtgo.Size = new System.Drawing.Size(72, 72);
			this._buttonVisitMtgo.TabIndex = 11;
			this._buttonVisitMtgo.Text = "Magic\r\nthe Gathering\r\nOnline";
			this._buttonVisitMtgo.TextAlign = System.Drawing.StringAlignment.Center;
			this._buttonVisitMtgo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// _buttonVisitCockatrice
			// 
			this._buttonVisitCockatrice.AutoCheck = false;
			this._buttonVisitCockatrice.BackColor = System.Drawing.Color.Transparent;
			this._buttonVisitCockatrice.Cursor = System.Windows.Forms.Cursors.Hand;
			this._buttonVisitCockatrice.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._buttonVisitCockatrice.ForeColor = System.Drawing.SystemColors.HotTrack;
			this._buttonVisitCockatrice.Image = global::Mtgdb.Gui.Properties.Resources.cockatrice_32;
			this._buttonVisitCockatrice.Location = new System.Drawing.Point(3, 464);
			this._buttonVisitCockatrice.Name = "_buttonVisitCockatrice";
			this._buttonVisitCockatrice.Padding = new System.Windows.Forms.Padding(4);
			this._buttonVisitCockatrice.Size = new System.Drawing.Size(72, 54);
			this._buttonVisitCockatrice.TabIndex = 13;
			this._buttonVisitCockatrice.Text = "Cockatrice";
			this._buttonVisitCockatrice.TextAlign = System.Drawing.StringAlignment.Center;
			this._buttonVisitCockatrice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// _buttonVisitDotP2014
			// 
			this._buttonVisitDotP2014.AutoCheck = false;
			this._buttonVisitDotP2014.BackColor = System.Drawing.Color.Transparent;
			this._buttonVisitDotP2014.Cursor = System.Windows.Forms.Cursors.Hand;
			this._buttonVisitDotP2014.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._buttonVisitDotP2014.ForeColor = System.Drawing.SystemColors.HotTrack;
			this._buttonVisitDotP2014.Image = global::Mtgdb.Gui.Properties.Resources.dot_p2014_32;
			this._buttonVisitDotP2014.Location = new System.Drawing.Point(3, 386);
			this._buttonVisitDotP2014.Name = "_buttonVisitDotP2014";
			this._buttonVisitDotP2014.Padding = new System.Windows.Forms.Padding(4);
			this._buttonVisitDotP2014.Size = new System.Drawing.Size(72, 72);
			this._buttonVisitDotP2014.TabIndex = 12;
			this._buttonVisitDotP2014.Text = "Riiak\'s\r\nDotP 2014\r\nDeck Builder";
			this._buttonVisitDotP2014.TextAlign = System.Drawing.StringAlignment.Center;
			this._buttonVisitDotP2014.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// _labelFormats
			// 
			this._labelFormats.AutoSize = true;
			this._menuOpen.SetColumnSpan(this._labelFormats, 3);
			this._labelFormats.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._labelFormats.Location = new System.Drawing.Point(3, 147);
			this._labelFormats.Margin = new System.Windows.Forms.Padding(3);
			this._labelFormats.Name = "_labelFormats";
			this._labelFormats.Size = new System.Drawing.Size(114, 14);
			this._labelFormats.TabIndex = 14;
			this._labelFormats.Text = "Supported formats:";
			this._labelFormats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _buttonVisitXMage
			// 
			this._buttonVisitXMage.AutoCheck = false;
			this._buttonVisitXMage.BackColor = System.Drawing.Color.Transparent;
			this._buttonVisitXMage.Cursor = System.Windows.Forms.Cursors.Hand;
			this._buttonVisitXMage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._buttonVisitXMage.ForeColor = System.Drawing.SystemColors.HotTrack;
			this._buttonVisitXMage.Image = global::Mtgdb.Gui.Properties.Resources.xmage_32;
			this._buttonVisitXMage.Location = new System.Drawing.Point(81, 167);
			this._buttonVisitXMage.Name = "_buttonVisitXMage";
			this._buttonVisitXMage.Padding = new System.Windows.Forms.Padding(4);
			this._buttonVisitXMage.Size = new System.Drawing.Size(54, 68);
			this._buttonVisitXMage.TabIndex = 5;
			this._buttonVisitXMage.Text = "XMage";
			this._buttonVisitXMage.TextAlign = System.Drawing.StringAlignment.Center;
			this._buttonVisitXMage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// _buttonVisitMagarena
			// 
			this._buttonVisitMagarena.AutoCheck = false;
			this._buttonVisitMagarena.BackColor = System.Drawing.Color.Transparent;
			this._buttonVisitMagarena.Cursor = System.Windows.Forms.Cursors.Hand;
			this._buttonVisitMagarena.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._buttonVisitMagarena.ForeColor = System.Drawing.SystemColors.HotTrack;
			this._buttonVisitMagarena.Image = global::Mtgdb.Gui.Properties.Resources.magarena_32;
			this._buttonVisitMagarena.Location = new System.Drawing.Point(141, 167);
			this._buttonVisitMagarena.Name = "_buttonVisitMagarena";
			this._buttonVisitMagarena.Padding = new System.Windows.Forms.Padding(4);
			this._buttonVisitMagarena.Size = new System.Drawing.Size(64, 68);
			this._buttonVisitMagarena.TabIndex = 6;
			this._buttonVisitMagarena.Text = "Magarena";
			this._buttonVisitMagarena.TextAlign = System.Drawing.StringAlignment.Center;
			this._buttonVisitMagarena.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// _buttonVisitDeckedBuilder
			// 
			this._buttonVisitDeckedBuilder.AutoCheck = false;
			this._buttonVisitDeckedBuilder.BackColor = System.Drawing.Color.Transparent;
			this._buttonVisitDeckedBuilder.Cursor = System.Windows.Forms.Cursors.Hand;
			this._buttonVisitDeckedBuilder.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._buttonVisitDeckedBuilder.ForeColor = System.Drawing.SystemColors.HotTrack;
			this._buttonVisitDeckedBuilder.Image = global::Mtgdb.Gui.Properties.Resources.decked_builder;
			this._buttonVisitDeckedBuilder.Location = new System.Drawing.Point(211, 167);
			this._buttonVisitDeckedBuilder.Name = "_buttonVisitDeckedBuilder";
			this._buttonVisitDeckedBuilder.Padding = new System.Windows.Forms.Padding(4);
			this._buttonVisitDeckedBuilder.Size = new System.Drawing.Size(59, 68);
			this._buttonVisitDeckedBuilder.TabIndex = 7;
			this._buttonVisitDeckedBuilder.Text = "Decked\r\nbuilder";
			this._buttonVisitDeckedBuilder.TextAlign = System.Drawing.StringAlignment.Center;
			this._buttonVisitDeckedBuilder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// _buttonVisitForge
			// 
			this._buttonVisitForge.AutoCheck = false;
			this._buttonVisitForge.BackColor = System.Drawing.Color.Transparent;
			this._buttonVisitForge.Cursor = System.Windows.Forms.Cursors.Hand;
			this._buttonVisitForge.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._buttonVisitForge.ForeColor = System.Drawing.SystemColors.HotTrack;
			this._buttonVisitForge.Image = global::Mtgdb.Gui.Properties.Resources.forge_32;
			this._buttonVisitForge.Location = new System.Drawing.Point(3, 167);
			this._buttonVisitForge.Name = "_buttonVisitForge";
			this._buttonVisitForge.Padding = new System.Windows.Forms.Padding(4);
			this._buttonVisitForge.Size = new System.Drawing.Size(72, 68);
			this._buttonVisitForge.TabIndex = 4;
			this._buttonVisitForge.Text = "Forge";
			this._buttonVisitForge.TextAlign = System.Drawing.StringAlignment.Center;
			this._buttonVisitForge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// _buttonVisitMtgArena
			// 
			this._buttonVisitMtgArena.AutoCheck = false;
			this._buttonVisitMtgArena.BackColor = System.Drawing.Color.Transparent;
			this._buttonVisitMtgArena.Cursor = System.Windows.Forms.Cursors.Hand;
			this._buttonVisitMtgArena.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._buttonVisitMtgArena.ForeColor = System.Drawing.SystemColors.HotTrack;
			this._buttonVisitMtgArena.Image = global::Mtgdb.Gui.Properties.Resources.MTGArena_32;
			this._buttonVisitMtgArena.Location = new System.Drawing.Point(3, 241);
			this._buttonVisitMtgArena.Name = "_buttonVisitMtgArena";
			this._buttonVisitMtgArena.Padding = new System.Windows.Forms.Padding(4);
			this._menuOpen.SetRowSpan(this._buttonVisitMtgArena, 2);
			this._buttonVisitMtgArena.Size = new System.Drawing.Size(72, 58);
			this._buttonVisitMtgArena.TabIndex = 8;
			this._buttonVisitMtgArena.Text = "MTGArena";
			this._buttonVisitMtgArena.TextAlign = System.Drawing.StringAlignment.Center;
			this._buttonVisitMtgArena.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// _buttonImportMtgArenaCollection
			// 
			this._buttonImportMtgArenaCollection.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonImportMtgArenaCollection.AutoCheck = false;
			this._buttonImportMtgArenaCollection.BackColor = System.Drawing.Color.Transparent;
			this._menuOpen.SetColumnSpan(this._buttonImportMtgArenaCollection, 3);
			this._buttonImportMtgArenaCollection.Cursor = System.Windows.Forms.Cursors.Hand;
			this._buttonImportMtgArenaCollection.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this._buttonImportMtgArenaCollection.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonImportMtgArenaCollection.Location = new System.Drawing.Point(81, 273);
			this._buttonImportMtgArenaCollection.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
			this._buttonImportMtgArenaCollection.Name = "_buttonImportMtgArenaCollection";
			this._buttonImportMtgArenaCollection.Padding = new System.Windows.Forms.Padding(4);
			this._buttonImportMtgArenaCollection.Size = new System.Drawing.Size(189, 32);
			this._buttonImportMtgArenaCollection.TabIndex = 10;
			this._buttonImportMtgArenaCollection.Text = "Import MTGArena collection";
			this._buttonImportMtgArenaCollection.VisibleAllBorders = true;
			this._buttonImportMtgArenaCollection.VisibleBorders = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// _menuLanguage
			// 
			this._menuLanguage.AutoSize = true;
			this._menuLanguage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._menuLanguage.BackColor = System.Drawing.SystemColors.Window;
			this._menuLanguage.ColumnCount = 3;
			this._menuLanguage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._menuLanguage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._menuLanguage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._menuLanguage.Controls.Add(this._buttonPT, 1, 3);
			this._menuLanguage.Controls.Add(this._buttonDE, 2, 1);
			this._menuLanguage.Controls.Add(this._buttonCN, 0, 0);
			this._menuLanguage.Controls.Add(this._buttonEN, 2, 0);
			this._menuLanguage.Controls.Add(this._buttonTW, 0, 3);
			this._menuLanguage.Controls.Add(this._buttonIT, 1, 2);
			this._menuLanguage.Controls.Add(this._buttonJP, 0, 1);
			this._menuLanguage.Controls.Add(this._buttonKR, 0, 2);
			this._menuLanguage.Controls.Add(this._buttonFR, 1, 1);
			this._menuLanguage.Controls.Add(this._buttonES, 1, 0);
			this._menuLanguage.Controls.Add(this._buttonRU, 2, 2);
			this._menuLanguage.Location = new System.Drawing.Point(349, 62);
			this._menuLanguage.Margin = new System.Windows.Forms.Padding(0);
			this._menuLanguage.Name = "_menuLanguage";
			this._menuLanguage.Padding = new System.Windows.Forms.Padding(1);
			this._menuLanguage.RowCount = 4;
			this._menuLanguage.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuLanguage.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuLanguage.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuLanguage.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuLanguage.Size = new System.Drawing.Size(176, 90);
			this._menuLanguage.TabIndex = 6;
			this._menuLanguage.Visible = false;
			this._menuLanguage.VisibleBorders = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// _buttonPT
			// 
			this._buttonPT.AutoCheck = false;
			this._buttonPT.BackColor = System.Drawing.Color.Transparent;
			this._buttonPT.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonPT.Image = global::Mtgdb.Gui.Properties.Resources.pt;
			this._buttonPT.Location = new System.Drawing.Point(59, 67);
			this._buttonPT.Margin = new System.Windows.Forms.Padding(0);
			this._buttonPT.Name = "_buttonPT";
			this._buttonPT.Padding = new System.Windows.Forms.Padding(4);
			this._buttonPT.Size = new System.Drawing.Size(58, 22);
			this._buttonPT.TabIndex = 7;
			this._buttonPT.Text = "PT";
			// 
			// _buttonDE
			// 
			this._buttonDE.AutoCheck = false;
			this._buttonDE.BackColor = System.Drawing.Color.Transparent;
			this._buttonDE.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonDE.Image = global::Mtgdb.Gui.Properties.Resources.de;
			this._buttonDE.Location = new System.Drawing.Point(117, 23);
			this._buttonDE.Margin = new System.Windows.Forms.Padding(0);
			this._buttonDE.Name = "_buttonDE";
			this._buttonDE.Padding = new System.Windows.Forms.Padding(4);
			this._buttonDE.Size = new System.Drawing.Size(58, 22);
			this._buttonDE.TabIndex = 9;
			this._buttonDE.Text = "DE";
			// 
			// _buttonCN
			// 
			this._buttonCN.AutoCheck = false;
			this._buttonCN.BackColor = System.Drawing.Color.Transparent;
			this._buttonCN.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonCN.Image = global::Mtgdb.Gui.Properties.Resources.cn;
			this._buttonCN.Location = new System.Drawing.Point(1, 1);
			this._buttonCN.Margin = new System.Windows.Forms.Padding(0);
			this._buttonCN.Name = "_buttonCN";
			this._buttonCN.Padding = new System.Windows.Forms.Padding(4);
			this._buttonCN.Size = new System.Drawing.Size(58, 22);
			this._buttonCN.TabIndex = 0;
			this._buttonCN.Text = "CN";
			// 
			// _buttonEN
			// 
			this._buttonEN.AutoCheck = false;
			this._buttonEN.BackColor = System.Drawing.Color.Transparent;
			this._buttonEN.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonEN.Image = global::Mtgdb.Gui.Properties.Resources.en;
			this._buttonEN.Location = new System.Drawing.Point(117, 1);
			this._buttonEN.Margin = new System.Windows.Forms.Padding(0);
			this._buttonEN.Name = "_buttonEN";
			this._buttonEN.Padding = new System.Windows.Forms.Padding(4);
			this._buttonEN.Size = new System.Drawing.Size(58, 22);
			this._buttonEN.TabIndex = 8;
			this._buttonEN.Text = "EN";
			// 
			// _buttonTW
			// 
			this._buttonTW.AutoCheck = false;
			this._buttonTW.BackColor = System.Drawing.Color.Transparent;
			this._buttonTW.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonTW.Image = global::Mtgdb.Gui.Properties.Resources.tw;
			this._buttonTW.Location = new System.Drawing.Point(1, 67);
			this._buttonTW.Margin = new System.Windows.Forms.Padding(0);
			this._buttonTW.Name = "_buttonTW";
			this._buttonTW.Padding = new System.Windows.Forms.Padding(4);
			this._buttonTW.Size = new System.Drawing.Size(58, 22);
			this._buttonTW.TabIndex = 3;
			this._buttonTW.Text = "TW";
			// 
			// _buttonIT
			// 
			this._buttonIT.AutoCheck = false;
			this._buttonIT.BackColor = System.Drawing.Color.Transparent;
			this._buttonIT.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonIT.Image = global::Mtgdb.Gui.Properties.Resources.it;
			this._buttonIT.Location = new System.Drawing.Point(59, 45);
			this._buttonIT.Margin = new System.Windows.Forms.Padding(0);
			this._buttonIT.Name = "_buttonIT";
			this._buttonIT.Padding = new System.Windows.Forms.Padding(4);
			this._buttonIT.Size = new System.Drawing.Size(58, 22);
			this._buttonIT.TabIndex = 6;
			this._buttonIT.Text = "IT";
			// 
			// _buttonJP
			// 
			this._buttonJP.AutoCheck = false;
			this._buttonJP.BackColor = System.Drawing.Color.Transparent;
			this._buttonJP.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonJP.Image = global::Mtgdb.Gui.Properties.Resources.jp;
			this._buttonJP.Location = new System.Drawing.Point(1, 23);
			this._buttonJP.Margin = new System.Windows.Forms.Padding(0);
			this._buttonJP.Name = "_buttonJP";
			this._buttonJP.Padding = new System.Windows.Forms.Padding(4);
			this._buttonJP.Size = new System.Drawing.Size(58, 22);
			this._buttonJP.TabIndex = 1;
			this._buttonJP.Text = "JP";
			// 
			// _buttonKR
			// 
			this._buttonKR.AutoCheck = false;
			this._buttonKR.BackColor = System.Drawing.Color.Transparent;
			this._buttonKR.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonKR.Image = global::Mtgdb.Gui.Properties.Resources.kr;
			this._buttonKR.Location = new System.Drawing.Point(1, 45);
			this._buttonKR.Margin = new System.Windows.Forms.Padding(0);
			this._buttonKR.Name = "_buttonKR";
			this._buttonKR.Padding = new System.Windows.Forms.Padding(4);
			this._buttonKR.Size = new System.Drawing.Size(58, 22);
			this._buttonKR.TabIndex = 2;
			this._buttonKR.Text = "KR";
			// 
			// _buttonFR
			// 
			this._buttonFR.AutoCheck = false;
			this._buttonFR.BackColor = System.Drawing.Color.Transparent;
			this._buttonFR.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonFR.Image = global::Mtgdb.Gui.Properties.Resources.fr;
			this._buttonFR.Location = new System.Drawing.Point(59, 23);
			this._buttonFR.Margin = new System.Windows.Forms.Padding(0);
			this._buttonFR.Name = "_buttonFR";
			this._buttonFR.Padding = new System.Windows.Forms.Padding(4);
			this._buttonFR.Size = new System.Drawing.Size(58, 22);
			this._buttonFR.TabIndex = 5;
			this._buttonFR.Text = "FR";
			// 
			// _buttonES
			// 
			this._buttonES.AutoCheck = false;
			this._buttonES.BackColor = System.Drawing.Color.Transparent;
			this._buttonES.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonES.Image = global::Mtgdb.Gui.Properties.Resources.es;
			this._buttonES.Location = new System.Drawing.Point(59, 1);
			this._buttonES.Margin = new System.Windows.Forms.Padding(0);
			this._buttonES.Name = "_buttonES";
			this._buttonES.Padding = new System.Windows.Forms.Padding(4);
			this._buttonES.Size = new System.Drawing.Size(58, 22);
			this._buttonES.TabIndex = 4;
			this._buttonES.Text = "ES";
			// 
			// _buttonRU
			// 
			this._buttonRU.AutoCheck = false;
			this._buttonRU.BackColor = System.Drawing.Color.Transparent;
			this._buttonRU.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonRU.Image = global::Mtgdb.Gui.Properties.Resources.ru;
			this._buttonRU.Location = new System.Drawing.Point(117, 45);
			this._buttonRU.Margin = new System.Windows.Forms.Padding(0);
			this._buttonRU.Name = "_buttonRU";
			this._buttonRU.Padding = new System.Windows.Forms.Padding(4);
			this._buttonRU.Size = new System.Drawing.Size(58, 22);
			this._buttonRU.TabIndex = 10;
			this._buttonRU.Text = "RU";
			// 
			// _menuDonate
			// 
			this._menuDonate.AutoSize = true;
			this._menuDonate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._menuDonate.BackColor = System.Drawing.SystemColors.Window;
			this._menuDonate.ColumnCount = 2;
			this._menuDonate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._menuDonate.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._menuDonate.Controls.Add(this._buttonMenuDonateYandexMoney, 0, 2);
			this._menuDonate.Controls.Add(this._panelAva, 0, 0);
			this._menuDonate.Controls.Add(this._buttonMenuDonatePayPal, 0, 1);
			this._menuDonate.Controls.Add(this._labelDonate, 1, 0);
			this._menuDonate.Location = new System.Drawing.Point(35, 62);
			this._menuDonate.Margin = new System.Windows.Forms.Padding(1);
			this._menuDonate.Name = "_menuDonate";
			this._menuDonate.RowCount = 3;
			this._menuDonate.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuDonate.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuDonate.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuDonate.Size = new System.Drawing.Size(243, 193);
			this._menuDonate.TabIndex = 2;
			this._menuDonate.Visible = false;
			this._menuDonate.VisibleBorders = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// _buttonMenuDonateYandexMoney
			// 
			this._buttonMenuDonateYandexMoney.AutoCheck = false;
			this._buttonMenuDonateYandexMoney.BackColor = System.Drawing.Color.Transparent;
			this._menuDonate.SetColumnSpan(this._buttonMenuDonateYandexMoney, 2);
			this._buttonMenuDonateYandexMoney.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonMenuDonateYandexMoney.Image = global::Mtgdb.Gui.Properties.Resources.yandex_money_32;
			this._buttonMenuDonateYandexMoney.Location = new System.Drawing.Point(2, 157);
			this._buttonMenuDonateYandexMoney.Margin = new System.Windows.Forms.Padding(2);
			this._buttonMenuDonateYandexMoney.Name = "_buttonMenuDonateYandexMoney";
			this._buttonMenuDonateYandexMoney.Padding = new System.Windows.Forms.Padding(4);
			this._buttonMenuDonateYandexMoney.Size = new System.Drawing.Size(239, 34);
			this._buttonMenuDonateYandexMoney.TabIndex = 1;
			this._buttonMenuDonateYandexMoney.Text = "Donate via YandexMoney";
			this._buttonMenuDonateYandexMoney.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			// 
			// _panelAva
			// 
			this._panelAva.BackgroundImage = global::Mtgdb.Gui.Properties.Resources.ava;
			this._panelAva.Location = new System.Drawing.Point(2, 2);
			this._panelAva.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
			this._panelAva.Name = "_panelAva";
			this._panelAva.Size = new System.Drawing.Size(87, 117);
			this._panelAva.TabIndex = 2;
			this._panelAva.VisibleBorders = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// _buttonMenuDonatePayPal
			// 
			this._buttonMenuDonatePayPal.AutoCheck = false;
			this._buttonMenuDonatePayPal.BackColor = System.Drawing.Color.Transparent;
			this._menuDonate.SetColumnSpan(this._buttonMenuDonatePayPal, 2);
			this._buttonMenuDonatePayPal.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonMenuDonatePayPal.Image = global::Mtgdb.Gui.Properties.Resources.paypal_32;
			this._buttonMenuDonatePayPal.Location = new System.Drawing.Point(2, 121);
			this._buttonMenuDonatePayPal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
			this._buttonMenuDonatePayPal.Name = "_buttonMenuDonatePayPal";
			this._buttonMenuDonatePayPal.Padding = new System.Windows.Forms.Padding(4);
			this._buttonMenuDonatePayPal.Size = new System.Drawing.Size(239, 34);
			this._buttonMenuDonatePayPal.TabIndex = 0;
			this._buttonMenuDonatePayPal.Text = "Donate via PayPal";
			this._buttonMenuDonatePayPal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			// 
			// _labelDonate
			// 
			this._labelDonate.Location = new System.Drawing.Point(94, 3);
			this._labelDonate.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
			this._labelDonate.Name = "_labelDonate";
			this._labelDonate.Size = new System.Drawing.Size(146, 116);
			this._labelDonate.TabIndex = 3;
			this._labelDonate.Text = "This application is free.\r\n\r\nIf you like it, consider donating to support its mai" +
    "ntenance and further development.\r\n\r\nThank you!";
			// 
			// _buttonPaste
			// 
			this._buttonPaste.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonPaste.AutoCheck = false;
			this._buttonPaste.BackColor = System.Drawing.Color.Transparent;
			this._buttonPaste.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonPaste.Image = global::Mtgdb.Gui.Properties.Resources.paste_16;
			this._buttonPaste.Location = new System.Drawing.Point(0, 3);
			this._buttonPaste.Margin = new System.Windows.Forms.Padding(0, 3, 12, 0);
			this._buttonPaste.Name = "_buttonPaste";
			this._buttonPaste.Padding = new System.Windows.Forms.Padding(4);
			this._buttonPaste.Size = new System.Drawing.Size(32, 24);
			this._buttonPaste.TabIndex = 0;
			// 
			// _menuPaste
			// 
			this._menuPaste.AutoSize = true;
			this._menuPaste.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._menuPaste.BackColor = System.Drawing.SystemColors.Window;
			this._menuPaste.ColumnCount = 1;
			this._menuPaste.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._menuPaste.Controls.Add(this._buttonMenuCopyCollection, 0, 5);
			this._menuPaste.Controls.Add(this._buttonMenuCopyDeck, 0, 4);
			this._menuPaste.Controls.Add(this._buttonMenuPasteCollectionAppend, 0, 3);
			this._menuPaste.Controls.Add(this._buttonMenuPasteCollection, 0, 2);
			this._menuPaste.Controls.Add(this._labelPasteInfo, 0, 6);
			this._menuPaste.Controls.Add(this._buttonMenuPasteDeck, 0, 0);
			this._menuPaste.Controls.Add(this._buttonMenuPasteDeckAppend, 0, 1);
			this._menuPaste.Location = new System.Drawing.Point(35, 289);
			this._menuPaste.Margin = new System.Windows.Forms.Padding(1);
			this._menuPaste.Name = "_menuPaste";
			this._menuPaste.RowCount = 7;
			this._menuPaste.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuPaste.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuPaste.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuPaste.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuPaste.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuPaste.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuPaste.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuPaste.Size = new System.Drawing.Size(303, 459);
			this._menuPaste.TabIndex = 5;
			this._menuPaste.Visible = false;
			this._menuPaste.VisibleBorders = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// _buttonMenuCopyCollection
			// 
			this._buttonMenuCopyCollection.AutoCheck = false;
			this._buttonMenuCopyCollection.BackColor = System.Drawing.Color.Transparent;
			this._buttonMenuCopyCollection.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonMenuCopyCollection.Location = new System.Drawing.Point(2, 182);
			this._buttonMenuCopyCollection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
			this._buttonMenuCopyCollection.Name = "_buttonMenuCopyCollection";
			this._buttonMenuCopyCollection.Padding = new System.Windows.Forms.Padding(4);
			this._buttonMenuCopyCollection.Size = new System.Drawing.Size(299, 34);
			this._buttonMenuCopyCollection.TabIndex = 5;
			this._buttonMenuCopyCollection.Text = "Copy Collection to Clipboard: Alt + C";
			// 
			// _buttonMenuCopyDeck
			// 
			this._buttonMenuCopyDeck.AutoCheck = false;
			this._buttonMenuCopyDeck.BackColor = System.Drawing.Color.Transparent;
			this._buttonMenuCopyDeck.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonMenuCopyDeck.Location = new System.Drawing.Point(2, 146);
			this._buttonMenuCopyDeck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
			this._buttonMenuCopyDeck.Name = "_buttonMenuCopyDeck";
			this._buttonMenuCopyDeck.Padding = new System.Windows.Forms.Padding(4);
			this._buttonMenuCopyDeck.Size = new System.Drawing.Size(299, 34);
			this._buttonMenuCopyDeck.TabIndex = 4;
			this._buttonMenuCopyDeck.Text = "Copy Deck to Clipboard: Ctrl + C";
			// 
			// _buttonMenuPasteCollectionAppend
			// 
			this._buttonMenuPasteCollectionAppend.AutoCheck = false;
			this._buttonMenuPasteCollectionAppend.BackColor = System.Drawing.Color.Transparent;
			this._buttonMenuPasteCollectionAppend.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonMenuPasteCollectionAppend.Location = new System.Drawing.Point(2, 110);
			this._buttonMenuPasteCollectionAppend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
			this._buttonMenuPasteCollectionAppend.Name = "_buttonMenuPasteCollectionAppend";
			this._buttonMenuPasteCollectionAppend.Padding = new System.Windows.Forms.Padding(4);
			this._buttonMenuPasteCollectionAppend.Size = new System.Drawing.Size(299, 34);
			this._buttonMenuPasteCollectionAppend.TabIndex = 3;
			this._buttonMenuPasteCollectionAppend.Text = "Add to Collection from Clipboard: Alt + Shift + V";
			// 
			// _buttonMenuPasteCollection
			// 
			this._buttonMenuPasteCollection.AutoCheck = false;
			this._buttonMenuPasteCollection.BackColor = System.Drawing.Color.Transparent;
			this._buttonMenuPasteCollection.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonMenuPasteCollection.Location = new System.Drawing.Point(2, 74);
			this._buttonMenuPasteCollection.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
			this._buttonMenuPasteCollection.Name = "_buttonMenuPasteCollection";
			this._buttonMenuPasteCollection.Padding = new System.Windows.Forms.Padding(4);
			this._buttonMenuPasteCollection.Size = new System.Drawing.Size(299, 34);
			this._buttonMenuPasteCollection.TabIndex = 2;
			this._buttonMenuPasteCollection.Text = "Create Collection from Clipboard: Alt + V";
			// 
			// _labelPasteInfo
			// 
			this._labelPasteInfo.Location = new System.Drawing.Point(3, 219);
			this._labelPasteInfo.Margin = new System.Windows.Forms.Padding(3);
			this._labelPasteInfo.Name = "_labelPasteInfo";
			this._labelPasteInfo.Size = new System.Drawing.Size(295, 237);
			this._labelPasteInfo.TabIndex = 6;
			this._labelPasteInfo.Text = resources.GetString("_labelPasteInfo.Text");
			this._labelPasteInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// _buttonMenuPasteDeck
			// 
			this._buttonMenuPasteDeck.AutoCheck = false;
			this._buttonMenuPasteDeck.BackColor = System.Drawing.Color.Transparent;
			this._buttonMenuPasteDeck.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonMenuPasteDeck.Location = new System.Drawing.Point(2, 2);
			this._buttonMenuPasteDeck.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
			this._buttonMenuPasteDeck.Name = "_buttonMenuPasteDeck";
			this._buttonMenuPasteDeck.Padding = new System.Windows.Forms.Padding(4);
			this._buttonMenuPasteDeck.Size = new System.Drawing.Size(299, 34);
			this._buttonMenuPasteDeck.TabIndex = 0;
			this._buttonMenuPasteDeck.Text = "Create new Deck from Clipboard: Ctrl + V";
			// 
			// _buttonMenuPasteDeckAppend
			// 
			this._buttonMenuPasteDeckAppend.AutoCheck = false;
			this._buttonMenuPasteDeckAppend.BackColor = System.Drawing.Color.Transparent;
			this._buttonMenuPasteDeckAppend.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonMenuPasteDeckAppend.Location = new System.Drawing.Point(2, 38);
			this._buttonMenuPasteDeckAppend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 0);
			this._buttonMenuPasteDeckAppend.Name = "_buttonMenuPasteDeckAppend";
			this._buttonMenuPasteDeckAppend.Padding = new System.Windows.Forms.Padding(4);
			this._buttonMenuPasteDeckAppend.Size = new System.Drawing.Size(299, 34);
			this._buttonMenuPasteDeckAppend.TabIndex = 1;
			this._buttonMenuPasteDeckAppend.Text = "Add to Deck from Clipboard: Ctrl + Shift + V";
			// 
			// _layoutTitle
			// 
			this._layoutTitle.ColumnCount = 3;
			this._layoutTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._layoutTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._layoutTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._layoutTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this._layoutTitle.Controls.Add(this._flowTitleRight, 2, 0);
			this._layoutTitle.Controls.Add(this._flowTitleLeft, 0, 0);
			this._layoutTitle.Controls.Add(this._tabs, 1, 0);
			this._layoutTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this._layoutTitle.Location = new System.Drawing.Point(0, 0);
			this._layoutTitle.Margin = new System.Windows.Forms.Padding(0);
			this._layoutTitle.Name = "_layoutTitle";
			this._layoutTitle.PaintBackground = false;
			this._layoutTitle.RowCount = 1;
			this._layoutTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._layoutTitle.Size = new System.Drawing.Size(907, 31);
			this._layoutTitle.TabIndex = 0;
			this._layoutTitle.VisibleBorders = System.Windows.Forms.AnchorStyles.Bottom;
			// 
			// _flowTitleRight
			// 
			this._flowTitleRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this._flowTitleRight.AutoSize = true;
			this._flowTitleRight.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._flowTitleRight.Controls.Add(this._buttonPaste);
			this._flowTitleRight.Controls.Add(this._buttonOpenDeck);
			this._flowTitleRight.Controls.Add(this._buttonSaveDeck);
			this._flowTitleRight.Controls.Add(this._buttonClear);
			this._flowTitleRight.Controls.Add(this._buttonPrint);
			this._flowTitleRight.Controls.Add(this._buttonStat);
			this._flowTitleRight.Controls.Add(this._buttonTooltips);
			this._flowTitleRight.Controls.Add(this._buttonShowFilterPanels);
			this._flowTitleRight.Controls.Add(this._buttonConfig);
			this._flowTitleRight.Controls.Add(this._buttonColorScheme);
			this._flowTitleRight.Controls.Add(this._buttonLanguage);
			this._flowTitleRight.Controls.Add(this._buttonHelp);
			this._flowTitleRight.Controls.Add(this._buttonUpdate);
			this._flowTitleRight.Controls.Add(this._buttonSupport);
			this._flowTitleRight.Controls.Add(this._buttonDonate);
			this._flowTitleRight.Location = new System.Drawing.Point(235, 3);
			this._flowTitleRight.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
			this._flowTitleRight.Name = "_flowTitleRight";
			this._flowTitleRight.PaintBackground = false;
			this._flowTitleRight.Size = new System.Drawing.Size(672, 27);
			this._flowTitleRight.TabIndex = 1;
			this._flowTitleRight.VisibleBorders = System.Windows.Forms.AnchorStyles.None;
			this._flowTitleRight.WrapContents = false;
			// 
			// _buttonShowFilterPanels
			// 
			this._buttonShowFilterPanels.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonShowFilterPanels.BackColor = System.Drawing.Color.Transparent;
			this._buttonShowFilterPanels.Checked = true;
			this._buttonShowFilterPanels.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonShowFilterPanels.Image = global::Mtgdb.Gui.Properties.Resources.filters_show_32;
			this._buttonShowFilterPanels.Location = new System.Drawing.Point(272, 3);
			this._buttonShowFilterPanels.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this._buttonShowFilterPanels.Name = "_buttonShowFilterPanels";
			this._buttonShowFilterPanels.Padding = new System.Windows.Forms.Padding(4);
			this._buttonShowFilterPanels.Size = new System.Drawing.Size(32, 24);
			this._buttonShowFilterPanels.TabIndex = 7;
			// 
			// _buttonColorScheme
			// 
			this._buttonColorScheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonColorScheme.AutoCheck = false;
			this._buttonColorScheme.BackColor = System.Drawing.Color.Transparent;
			this._buttonColorScheme.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonColorScheme.Image = global::Mtgdb.Gui.Properties.Resources.color_swatch_32;
			this._buttonColorScheme.Location = new System.Drawing.Point(336, 3);
			this._buttonColorScheme.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
			this._buttonColorScheme.Name = "_buttonColorScheme";
			this._buttonColorScheme.Padding = new System.Windows.Forms.Padding(4);
			this._buttonColorScheme.Size = new System.Drawing.Size(32, 24);
			this._buttonColorScheme.TabIndex = 9;
			// 
			// _buttonSupport
			// 
			this._buttonSupport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonSupport.AutoCheck = false;
			this._buttonSupport.BackColor = System.Drawing.Color.Transparent;
			this._buttonSupport.ForeColor = System.Drawing.SystemColors.WindowText;
			this._buttonSupport.Location = new System.Drawing.Point(508, 3);
			this._buttonSupport.Margin = new System.Windows.Forms.Padding(0, 3, 3, 0);
			this._buttonSupport.Name = "_buttonSupport";
			this._buttonSupport.Padding = new System.Windows.Forms.Padding(4);
			this._buttonSupport.Size = new System.Drawing.Size(111, 24);
			this._buttonSupport.TabIndex = 13;
			this._buttonSupport.Text = "Support & feedback";
			// 
			// _flowTitleLeft
			// 
			this._flowTitleLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this._flowTitleLeft.AutoSize = true;
			this._flowTitleLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._flowTitleLeft.Controls.Add(this._buttonUndo);
			this._flowTitleLeft.Controls.Add(this._buttonRedo);
			this._flowTitleLeft.Controls.Add(this._buttonOpenWindow);
			this._flowTitleLeft.Location = new System.Drawing.Point(0, 3);
			this._flowTitleLeft.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
			this._flowTitleLeft.Name = "_flowTitleLeft";
			this._flowTitleLeft.PaintBackground = false;
			this._flowTitleLeft.Size = new System.Drawing.Size(108, 27);
			this._flowTitleLeft.TabIndex = 0;
			this._flowTitleLeft.VisibleBorders = System.Windows.Forms.AnchorStyles.None;
			this._flowTitleLeft.WrapContents = false;
			// 
			// _buttonOpenWindow
			// 
			this._buttonOpenWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonOpenWindow.AutoCheck = false;
			this._buttonOpenWindow.BackColor = System.Drawing.Color.Transparent;
			this._buttonOpenWindow.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonOpenWindow.Image = global::Mtgdb.Gui.Properties.Resources.add_form_32;
			this._buttonOpenWindow.Location = new System.Drawing.Point(64, 3);
			this._buttonOpenWindow.Margin = new System.Windows.Forms.Padding(0, 3, 12, 0);
			this._buttonOpenWindow.Name = "_buttonOpenWindow";
			this._buttonOpenWindow.Padding = new System.Windows.Forms.Padding(4);
			this._buttonOpenWindow.Size = new System.Drawing.Size(32, 24);
			this._buttonOpenWindow.TabIndex = 2;
			// 
			// _menuColors
			// 
			this._menuColors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuItemEditColorScheme});
			this._menuColors.Name = "_menuColors";
			this._menuColors.Size = new System.Drawing.Size(169, 26);
			// 
			// _menuItemEditColorScheme
			// 
			this._menuItemEditColorScheme.Name = "_menuItemEditColorScheme";
			this._menuItemEditColorScheme.Size = new System.Drawing.Size(168, 22);
			this._menuItemEditColorScheme.Text = "Edit color scheme";
			// 
			// _menuConfig
			// 
			this._menuConfig.AutoSize = true;
			this._menuConfig.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this._menuConfig.BackColor = System.Drawing.SystemColors.Window;
			this._menuConfig.ColumnCount = 3;
			this._menuConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this._menuConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._menuConfig.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this._menuConfig.Controls.Add(this._menuUiUndoDepth, 2, 5);
			this._menuConfig.Controls.Add(this._menuUiImagesCacheCapacity, 2, 4);
			this._menuConfig.Controls.Add(this._labelUiUndoDepth, 0, 5);
			this._menuConfig.Controls.Add(this._labelUiImageCacheCapacity, 0, 4);
			this._menuConfig.Controls.Add(this._labelUiSuggestDownloadMissingImages, 0, 3);
			this._menuConfig.Controls.Add(this._labelUiUseSmallImagesHint, 0, 2);
			this._menuConfig.Controls.Add(this._labelUiScale, 0, 0);
			this._menuConfig.Controls.Add(this._menuUiScale, 2, 0);
			this._menuConfig.Controls.Add(this._buttonMenuEditConfig, 0, 6);
			this._menuConfig.Controls.Add(this._labelUiUseSmallImages, 0, 1);
			this._menuConfig.Controls.Add(this._menuUiSmallImageQuality, 1, 1);
			this._menuConfig.Controls.Add(this._menuUiSuggestDownloadMissingImages, 2, 3);
			this._menuConfig.Location = new System.Drawing.Point(653, 62);
			this._menuConfig.Name = "_menuConfig";
			this._menuConfig.RowCount = 7;
			this._menuConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuConfig.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this._menuConfig.Size = new System.Drawing.Size(188, 257);
			this._menuConfig.TabIndex = 3;
			this._menuConfig.VisibleBorders = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			// 
			// _menuUiUndoDepth
			// 
			this._menuUiUndoDepth.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this._menuUiUndoDepth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._menuUiUndoDepth.FormattingEnabled = true;
			this._menuUiUndoDepth.Location = new System.Drawing.Point(125, 178);
			this._menuUiUndoDepth.Name = "_menuUiUndoDepth";
			this._menuUiUndoDepth.Size = new System.Drawing.Size(60, 21);
			this._menuUiUndoDepth.TabIndex = 4;
			this._menuUiUndoDepth.TabStop = false;
			// 
			// _menuUiImagesCacheCapacity
			// 
			this._menuUiImagesCacheCapacity.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this._menuUiImagesCacheCapacity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._menuUiImagesCacheCapacity.FormattingEnabled = true;
			this._menuUiImagesCacheCapacity.Location = new System.Drawing.Point(125, 151);
			this._menuUiImagesCacheCapacity.Name = "_menuUiImagesCacheCapacity";
			this._menuUiImagesCacheCapacity.Size = new System.Drawing.Size(60, 21);
			this._menuUiImagesCacheCapacity.TabIndex = 3;
			this._menuUiImagesCacheCapacity.TabStop = false;
			// 
			// _labelUiUndoDepth
			// 
			this._labelUiUndoDepth.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this._labelUiUndoDepth.AutoSize = true;
			this._menuConfig.SetColumnSpan(this._labelUiUndoDepth, 2);
			this._labelUiUndoDepth.Location = new System.Drawing.Point(56, 182);
			this._labelUiUndoDepth.Name = "_labelUiUndoDepth";
			this._labelUiUndoDepth.Size = new System.Drawing.Size(63, 13);
			this._labelUiUndoDepth.TabIndex = 10;
			this._labelUiUndoDepth.Text = "Undo depth";
			// 
			// _labelUiImageCacheCapacity
			// 
			this._labelUiImageCacheCapacity.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this._labelUiImageCacheCapacity.AutoSize = true;
			this._menuConfig.SetColumnSpan(this._labelUiImageCacheCapacity, 2);
			this._labelUiImageCacheCapacity.Location = new System.Drawing.Point(3, 155);
			this._labelUiImageCacheCapacity.Name = "_labelUiImageCacheCapacity";
			this._labelUiImageCacheCapacity.Size = new System.Drawing.Size(116, 13);
			this._labelUiImageCacheCapacity.TabIndex = 9;
			this._labelUiImageCacheCapacity.Text = "Images cache capacity";
			// 
			// _labelUiSuggestDownloadMissingImages
			// 
			this._labelUiSuggestDownloadMissingImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._menuConfig.SetColumnSpan(this._labelUiSuggestDownloadMissingImages, 2);
			this._labelUiSuggestDownloadMissingImages.Location = new System.Drawing.Point(21, 119);
			this._labelUiSuggestDownloadMissingImages.Name = "_labelUiSuggestDownloadMissingImages";
			this._labelUiSuggestDownloadMissingImages.Size = new System.Drawing.Size(98, 29);
			this._labelUiSuggestDownloadMissingImages.TabIndex = 8;
			this._labelUiSuggestDownloadMissingImages.Text = "Suggest download missing images";
			this._labelUiSuggestDownloadMissingImages.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _labelUiUseSmallImagesHint
			// 
			this._labelUiUseSmallImagesHint.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this._menuConfig.SetColumnSpan(this._labelUiUseSmallImagesHint, 3);
			this._labelUiUseSmallImagesHint.Location = new System.Drawing.Point(3, 59);
			this._labelUiUseSmallImagesHint.Margin = new System.Windows.Forms.Padding(3, 3, 3, 18);
			this._labelUiUseSmallImagesHint.Name = "_labelUiUseSmallImagesHint";
			this._labelUiUseSmallImagesHint.Size = new System.Drawing.Size(182, 42);
			this._labelUiUseSmallImagesHint.TabIndex = 7;
			this._labelUiUseSmallImagesHint.Text = "\"High (MQ)\" is recommended when\r\n- User Interface scale > 100% or\r\n- Windows DPI " +
    "setting > 96 dpi";
			// 
			// _labelUiScale
			// 
			this._labelUiScale.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this._labelUiScale.AutoSize = true;
			this._menuConfig.SetColumnSpan(this._labelUiScale, 2);
			this._labelUiScale.Location = new System.Drawing.Point(15, 7);
			this._labelUiScale.Name = "_labelUiScale";
			this._labelUiScale.Size = new System.Drawing.Size(104, 13);
			this._labelUiScale.TabIndex = 5;
			this._labelUiScale.Text = "User Interface scale";
			// 
			// _menuUiScale
			// 
			this._menuUiScale.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this._menuUiScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._menuUiScale.FormattingEnabled = true;
			this._menuUiScale.Location = new System.Drawing.Point(125, 3);
			this._menuUiScale.Name = "_menuUiScale";
			this._menuUiScale.Size = new System.Drawing.Size(60, 21);
			this._menuUiScale.TabIndex = 0;
			this._menuUiScale.TabStop = false;
			// 
			// _buttonMenuEditConfig
			// 
			this._buttonMenuEditConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this._buttonMenuEditConfig.AutoCheck = false;
			this._buttonMenuEditConfig.BackColor = System.Drawing.Color.Transparent;
			this._menuConfig.SetColumnSpan(this._buttonMenuEditConfig, 3);
			this._buttonMenuEditConfig.ForeColor = System.Drawing.SystemColors.ControlText;
			this._buttonMenuEditConfig.Location = new System.Drawing.Point(3, 220);
			this._buttonMenuEditConfig.Margin = new System.Windows.Forms.Padding(3, 18, 3, 3);
			this._buttonMenuEditConfig.Name = "_buttonMenuEditConfig";
			this._buttonMenuEditConfig.Padding = new System.Windows.Forms.Padding(4);
			this._buttonMenuEditConfig.Size = new System.Drawing.Size(182, 34);
			this._buttonMenuEditConfig.TabIndex = 4;
			this._buttonMenuEditConfig.Text = "Edit configuration file";
			this._buttonMenuEditConfig.Visible = false;
			// 
			// _labelUiUseSmallImages
			// 
			this._labelUiUseSmallImages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this._labelUiUseSmallImages.Location = new System.Drawing.Point(3, 27);
			this._labelUiUseSmallImages.Name = "_labelUiUseSmallImages";
			this._labelUiUseSmallImages.Size = new System.Drawing.Size(83, 29);
			this._labelUiUseSmallImages.TabIndex = 6;
			this._labelUiUseSmallImages.Text = "Small image quality";
			this._labelUiUseSmallImages.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// _menuUiSmallImageQuality
			// 
			this._menuUiSmallImageQuality.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this._menuConfig.SetColumnSpan(this._menuUiSmallImageQuality, 2);
			this._menuUiSmallImageQuality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._menuUiSmallImageQuality.FormattingEnabled = true;
			this._menuUiSmallImageQuality.Location = new System.Drawing.Point(95, 31);
			this._menuUiSmallImageQuality.Name = "_menuUiSmallImageQuality";
			this._menuUiSmallImageQuality.Size = new System.Drawing.Size(90, 21);
			this._menuUiSmallImageQuality.TabIndex = 1;
			this._menuUiSmallImageQuality.TabStop = false;
			// 
			// _menuUiSuggestDownloadMissingImages
			// 
			this._menuUiSuggestDownloadMissingImages.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this._menuUiSuggestDownloadMissingImages.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this._menuUiSuggestDownloadMissingImages.FormattingEnabled = true;
			this._menuUiSuggestDownloadMissingImages.Location = new System.Drawing.Point(125, 123);
			this._menuUiSuggestDownloadMissingImages.Name = "_menuUiSuggestDownloadMissingImages";
			this._menuUiSuggestDownloadMissingImages.Size = new System.Drawing.Size(60, 21);
			this._menuUiSuggestDownloadMissingImages.TabIndex = 2;
			this._menuUiSuggestDownloadMissingImages.TabStop = false;
			// 
			// FormRoot
			// 
			this.CaptionHeight = 37;
			this.ClientSize = new System.Drawing.Size(1024, 800);
			this.Controls.Add(this._menuConfig);
			this.Controls.Add(this._menuPaste);
			this.Controls.Add(this._menuOpen);
			this.Controls.Add(this._menuLanguage);
			this.Controls.Add(this._menuDonate);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F);
			this.Location = new System.Drawing.Point(0, 0);
			this.Name = "FormRoot";
			this.Text = "FormTabbed";
			this.Controls.SetChildIndex(this._panelClient, 0);
			this.Controls.SetChildIndex(this._panelCaption, 0);
			this.Controls.SetChildIndex(this._menuDonate, 0);
			this.Controls.SetChildIndex(this._menuLanguage, 0);
			this.Controls.SetChildIndex(this._menuOpen, 0);
			this.Controls.SetChildIndex(this._menuPaste, 0);
			this.Controls.SetChildIndex(this._menuConfig, 0);
			this._panelCaption.ResumeLayout(false);
			this._menuOpen.ResumeLayout(false);
			this._menuOpen.PerformLayout();
			this._menuLanguage.ResumeLayout(false);
			this._menuDonate.ResumeLayout(false);
			this._menuPaste.ResumeLayout(false);
			this._layoutTitle.ResumeLayout(false);
			this._layoutTitle.PerformLayout();
			this._flowTitleRight.ResumeLayout(false);
			this._flowTitleLeft.ResumeLayout(false);
			this._menuColors.ResumeLayout(false);
			this._menuConfig.ResumeLayout(false);
			this._menuConfig.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private Mtgdb.Controls.CustomCheckBox _buttonUndo;
		private Mtgdb.Controls.CustomCheckBox _buttonRedo;
		private Mtgdb.Controls.CustomCheckBox _buttonDonate;
		private Mtgdb.Controls.CustomCheckBox _buttonUpdate;
		private Mtgdb.Controls.CustomCheckBox _buttonLanguage;
		private Mtgdb.Controls.CustomCheckBox _buttonConfig;
		private Mtgdb.Controls.CustomCheckBox _buttonHelp;
		private Mtgdb.Controls.CustomCheckBox _buttonOpenDeck;
		private Mtgdb.Controls.CustomCheckBox _buttonSaveDeck;
		private Mtgdb.Controls.CustomCheckBox _buttonStat;
		private Mtgdb.Controls.CustomCheckBox _buttonPrint;
		private Mtgdb.Controls.CustomCheckBox _buttonClear;
		private Mtgdb.Controls.CustomCheckBox _buttonTooltips;
		private Controls.TabHeaderControl _tabs;
		private Mtgdb.Controls.CustomCheckBox _buttonVisitForge;
		private Mtgdb.Controls.CustomCheckBox _buttonVisitXMage;
		private Mtgdb.Controls.CustomCheckBox _buttonVisitMagarena;
		private Mtgdb.Controls.CustomCheckBox _buttonVisitCockatrice;
		private Mtgdb.Controls.CustomCheckBox _buttonVisitDotP2014;
		private System.Windows.Forms.Label _labelFormats;
		private System.Windows.Forms.Label _labelMagarena;
		private System.Windows.Forms.Label _labelDotP2;
		private Mtgdb.Controls.CustomCheckBox _buttonPT;
		private Mtgdb.Controls.CustomCheckBox _buttonTW;
		private Mtgdb.Controls.CustomCheckBox _buttonRU;
		private Mtgdb.Controls.CustomCheckBox _buttonIT;
		private Mtgdb.Controls.CustomCheckBox _buttonKR;
		private Mtgdb.Controls.CustomCheckBox _buttonDE;
		private Mtgdb.Controls.CustomCheckBox _buttonFR;
		private Mtgdb.Controls.CustomCheckBox _buttonJP;
		private Mtgdb.Controls.CustomCheckBox _buttonEN;
		private Mtgdb.Controls.CustomCheckBox _buttonES;
		private Mtgdb.Controls.CustomCheckBox _buttonCN;
		private Mtgdb.Controls.BorderedPanel _panelAva;
		private Mtgdb.Controls.CustomCheckBox _buttonMenuDonatePayPal;
		private Mtgdb.Controls.CustomCheckBox _buttonMenuDonateYandexMoney;
		private System.Windows.Forms.Label _labelDonate;
		private Controls.CustomCheckBox _buttonMenuOpenDeck;
		private Controls.CustomCheckBox _buttonMenuOpenCollection;
		private Controls.CustomCheckBox _buttonVisitMtgo;
		private Controls.CustomCheckBox _buttonMenuSaveDeck;
		private Controls.CustomCheckBox _buttonMenuSaveCollection;
		private System.Windows.Forms.Label _labelMtgo;
		private Controls.CustomCheckBox _buttonPaste;
		private System.Windows.Forms.Label _labelPasteInfo;
		private Controls.CustomCheckBox _buttonMenuPasteDeckAppend;
		private Controls.CustomCheckBox _buttonMenuPasteDeck;
		private Mtgdb.Controls.BorderedTableLayoutPanel _menuOpen;
		private Mtgdb.Controls.BorderedTableLayoutPanel _menuPaste;
		private Mtgdb.Controls.BorderedTableLayoutPanel _menuDonate;
		private Mtgdb.Controls.BorderedTableLayoutPanel _menuLanguage;
		private Mtgdb.Controls.BorderedTableLayoutPanel _layoutTitle;
		private Mtgdb.Controls.BorderedFlowLayoutPanel _flowTitleLeft;
		private Mtgdb.Controls.BorderedFlowLayoutPanel _flowTitleRight;
		private Mtgdb.Controls.CustomCheckBox _buttonMenuPasteCollectionAppend;
		private Mtgdb.Controls.CustomCheckBox _buttonMenuPasteCollection;
		private Mtgdb.Controls.CustomCheckBox _buttonMenuCopyDeck;
		private Mtgdb.Controls.CustomCheckBox _buttonMenuCopyCollection;
		private Mtgdb.Controls.CustomCheckBox _buttonShowFilterPanels;
		private Mtgdb.Controls.CustomCheckBox _buttonOpenWindow;
		private Mtgdb.Controls.CustomCheckBox _buttonSupport;
		private Mtgdb.Controls.CustomCheckBox _buttonVisitDeckedBuilder;
		private Mtgdb.Controls.CustomCheckBox _buttonVisitMtgArena;
		private Mtgdb.Controls.CustomCheckBox _buttonImportExportToMtgArena;
		private Mtgdb.Controls.CustomCheckBox _buttonColorScheme;
		private Controls.CustomCheckBox _buttonImportMtgArenaCollection;
		private ContextMenuStrip _menuColors;
		private ToolStripMenuItem _menuItemEditColorScheme;
		private Controls.BorderedTableLayoutPanel _menuConfig;
		private Controls.CustomCheckBox _buttonMenuEditConfig;
		private Label _labelUiScale;
		private ComboBox _menuUiScale;
		private Label _labelUiUseSmallImages;
		private ComboBox _menuUiSmallImageQuality;
		private Label _labelUiUseSmallImagesHint;
		private Label _labelUiUndoDepth;
		private Label _labelUiImageCacheCapacity;
		private Label _labelUiSuggestDownloadMissingImages;
		private ComboBox _menuUiSuggestDownloadMissingImages;
		private ComboBox _menuUiImagesCacheCapacity;
		private ComboBox _menuUiUndoDepth;
	}
}