namespace BibliothekUI
{
    partial class MenuBibliothek
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      components = new System.ComponentModel.Container();
      menuStrip1 = new MenuStrip();
      dateiToolStripMenuItem = new ToolStripMenuItem();
      neuToolStripMenuItem = new ToolStripMenuItem();
      offnenToolStripMenuItem = new ToolStripMenuItem();
      toolStripSeparator1 = new ToolStripSeparator();
      speichernToolStripMenuItem = new ToolStripMenuItem();
      buchToolStripMenuItem = new ToolStripMenuItem();
      newuToolStripMenuItem = new ToolStripMenuItem();
      contextMenuStrip1 = new ContextMenuStrip(components);
      listViewMenu = new ListView();
      columnHeaderBuchNummer = new ColumnHeader();
      columnHeaderBuchName = new ColumnHeader();
      columnHeaderAutor = new ColumnHeader();
      columnHeaderPage = new ColumnHeader();
      columnHeaderLanguage = new ColumnHeader();
      columnHeaderPublishYear = new ColumnHeader();
      columnHeaderNote = new ColumnHeader();
      statusStrip1 = new StatusStrip();
      statusLabelDatei = new ToolStripStatusLabel();
      menuStrip1.SuspendLayout();
      statusStrip1.SuspendLayout();
      SuspendLayout();
      // 
      // menuStrip1
      // 
      menuStrip1.Items.AddRange(new ToolStripItem[] { dateiToolStripMenuItem, buchToolStripMenuItem });
      menuStrip1.Location = new Point(0, 0);
      menuStrip1.Name = "menuStrip1";
      menuStrip1.Size = new Size(876, 24);
      menuStrip1.TabIndex = 0;
      menuStrip1.Text = "menuStrip1";
      // 
      // dateiToolStripMenuItem
      // 
      dateiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { neuToolStripMenuItem, offnenToolStripMenuItem, toolStripSeparator1, speichernToolStripMenuItem });
      dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
      dateiToolStripMenuItem.Size = new Size(46, 20);
      dateiToolStripMenuItem.Text = "Datei";
      // 
      // neuToolStripMenuItem
      // 
      neuToolStripMenuItem.Name = "neuToolStripMenuItem";
      neuToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
      neuToolStripMenuItem.Size = new Size(180, 22);
      neuToolStripMenuItem.Text = "Neu";
      neuToolStripMenuItem.Click += neuToolStripMenuItem_Click;
      // 
      // offnenToolStripMenuItem
      // 
      offnenToolStripMenuItem.Name = "offnenToolStripMenuItem";
      offnenToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
      offnenToolStripMenuItem.Size = new Size(180, 22);
      offnenToolStripMenuItem.Text = "Offnen";
      // 
      // toolStripSeparator1
      // 
      toolStripSeparator1.Name = "toolStripSeparator1";
      toolStripSeparator1.Size = new Size(177, 6);
      // 
      // speichernToolStripMenuItem
      // 
      speichernToolStripMenuItem.Name = "speichernToolStripMenuItem";
      speichernToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
      speichernToolStripMenuItem.Size = new Size(180, 22);
      speichernToolStripMenuItem.Text = "Speichern";
      speichernToolStripMenuItem.Click += speichernToolStripMenuItem_Click;
      // 
      // buchToolStripMenuItem
      // 
      buchToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newuToolStripMenuItem });
      buchToolStripMenuItem.Name = "buchToolStripMenuItem";
      buchToolStripMenuItem.Size = new Size(46, 20);
      buchToolStripMenuItem.Text = "Buch";
      // 
      // newuToolStripMenuItem
      // 
      newuToolStripMenuItem.Name = "newuToolStripMenuItem";
      newuToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
      newuToolStripMenuItem.Size = new Size(137, 22);
      newuToolStripMenuItem.Text = "Neu";
      newuToolStripMenuItem.Click += newuToolStripMenuItem_Click;
      // 
      // contextMenuStrip1
      // 
      contextMenuStrip1.Name = "contextMenuStrip1";
      contextMenuStrip1.Size = new Size(61, 4);
      // 
      // listViewMenu
      // 
      listViewMenu.BackColor = Color.LightGray;
      listViewMenu.Columns.AddRange(new ColumnHeader[] { columnHeaderBuchNummer, columnHeaderBuchName, columnHeaderAutor, columnHeaderPage, columnHeaderLanguage, columnHeaderPublishYear, columnHeaderNote });
      listViewMenu.FullRowSelect = true;
      listViewMenu.GridLines = true;
      listViewMenu.Location = new Point(0, 27);
      listViewMenu.Name = "listViewMenu";
      listViewMenu.Size = new Size(876, 245);
      listViewMenu.TabIndex = 1;
      listViewMenu.UseCompatibleStateImageBehavior = false;
      listViewMenu.View = View.Details;
      listViewMenu.MouseDoubleClick += listViewMenu_MouseDoubleClick;
      // 
      // columnHeaderBuchNummer
      // 
      columnHeaderBuchNummer.Text = "Buch-Nummer";
      columnHeaderBuchNummer.Width = 100;
      // 
      // columnHeaderBuchName
      // 
      columnHeaderBuchName.Text = "Name";
      columnHeaderBuchName.Width = 150;
      // 
      // columnHeaderAutor
      // 
      columnHeaderAutor.Text = "Autor";
      columnHeaderAutor.Width = 150;
      // 
      // columnHeaderPage
      // 
      columnHeaderPage.Text = "Seite Anzahl ";
      columnHeaderPage.Width = 100;
      // 
      // columnHeaderLanguage
      // 
      columnHeaderLanguage.Text = "Language";
      columnHeaderLanguage.Width = 100;
      // 
      // columnHeaderPublishYear
      // 
      columnHeaderPublishYear.Text = "Erscheinungsdatum";
      columnHeaderPublishYear.Width = 130;
      // 
      // columnHeaderNote
      // 
      columnHeaderNote.Text = "Note";
      columnHeaderNote.Width = 150;
      // 
      // statusStrip1
      // 
      statusStrip1.Items.AddRange(new ToolStripItem[] { statusLabelDatei });
      statusStrip1.Location = new Point(0, 275);
      statusStrip1.Name = "statusStrip1";
      statusStrip1.Size = new Size(876, 24);
      statusStrip1.TabIndex = 2;
      statusStrip1.Text = "keine Datei geoffnet";
      // 
      // statusLabelDatei
      // 
      statusLabelDatei.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
      statusLabelDatei.BorderStyle = Border3DStyle.SunkenInner;
      statusLabelDatei.Name = "statusLabelDatei";
      statusLabelDatei.Size = new Size(117, 19);
      statusLabelDatei.Text = "keine Datei geoffnet";
      // 
      // MenuBibliothek
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      ClientSize = new Size(876, 299);
      Controls.Add(statusStrip1);
      Controls.Add(listViewMenu);
      Controls.Add(menuStrip1);
      MainMenuStrip = menuStrip1;
      Name = "MenuBibliothek";
      StartPosition = FormStartPosition.CenterScreen;
      Text = "Menu";
      menuStrip1.ResumeLayout(false);
      menuStrip1.PerformLayout();
      statusStrip1.ResumeLayout(false);
      statusStrip1.PerformLayout();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private MenuStrip menuStrip1;
    private ToolStripMenuItem dateiToolStripMenuItem;
    private ToolStripMenuItem neuToolStripMenuItem;
    private ToolStripMenuItem offnenToolStripMenuItem;
    private ToolStripMenuItem speichernToolStripMenuItem;
    private ToolStripMenuItem buchToolStripMenuItem;
    private ContextMenuStrip contextMenuStrip1;
    private ToolStripMenuItem newuToolStripMenuItem;
    private ToolStripSeparator toolStripSeparator1;
    private ListView listViewMenu;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel statusLabelDatei;
    private ColumnHeader columnHeaderBuchNummer;
    private ColumnHeader columnHeaderBuchName;
    private ColumnHeader columnHeaderAutor;
    private ColumnHeader columnHeaderPage;
    private ColumnHeader columnHeaderLanguage;
    private ColumnHeader columnHeaderNote;
    private ColumnHeader columnHeaderPublishYear;
  }
}
