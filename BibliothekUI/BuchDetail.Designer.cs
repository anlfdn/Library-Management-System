namespace BibliothekUI {
  partial class BuchDetail {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
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
    private void InitializeComponent() {
      pictureBoxBuch = new PictureBox();
      labelName = new Label();
      labelAutor = new Label();
      labelSeiteAnzahl = new Label();
      labelLanguage = new Label();
      labelPublishYear = new Label();
      textBoxName = new TextBox();
      textBoxAutor = new TextBox();
      textBoxSeiteAnzahl = new TextBox();
      textBoxLanguage = new TextBox();
      textBoxNote = new TextBox();
      dateTimePickerErscheinung = new DateTimePicker();
      labelNote = new Label();
      tabControlBuch = new TabControl();
      tabPage1 = new TabPage();
      flowLayoutPanelBestand = new FlowLayoutPanel();
      buttonNeuBestand = new Button();
      listViewBestand = new ListView();
      columnHeaderAnzahl = new ColumnHeader();
      columnHeaderVerfugbar = new ColumnHeader();
      tabPageStandort = new TabPage();
      flowLayoutPanelStandort = new FlowLayoutPanel();
      listViewStandort = new ListView();
      columnHeaderShelf = new ColumnHeader();
      columnHeaderReihe = new ColumnHeader();
      columnHeaderPosition = new ColumnHeader();
      buttonNeuStandort = new Button();
      tabPage3 = new TabPage();
      flowLayoutPanelReservierung = new FlowLayoutPanel();
      buttonNeuReservierung = new Button();
      buttonSpeichern = new Button();
      buttonAbbrechen = new Button();
      labelIdNumber = new Label();
      ((System.ComponentModel.ISupportInitialize)pictureBoxBuch).BeginInit();
      tabControlBuch.SuspendLayout();
      tabPage1.SuspendLayout();
      tabPageStandort.SuspendLayout();
      tabPage3.SuspendLayout();
      SuspendLayout();
      // 
      // pictureBoxBuch
      // 
      pictureBoxBuch.BorderStyle = BorderStyle.Fixed3D;
      pictureBoxBuch.Location = new Point(12, 35);
      pictureBoxBuch.Name = "pictureBoxBuch";
      pictureBoxBuch.Size = new Size(212, 290);
      pictureBoxBuch.TabIndex = 0;
      pictureBoxBuch.TabStop = false;
      // 
      // labelName
      // 
      labelName.AutoSize = true;
      labelName.Location = new Point(265, 35);
      labelName.Name = "labelName";
      labelName.Size = new Size(39, 15);
      labelName.TabIndex = 1;
      labelName.Text = "Name";
      // 
      // labelAutor
      // 
      labelAutor.AutoSize = true;
      labelAutor.Location = new Point(265, 85);
      labelAutor.Name = "labelAutor";
      labelAutor.Size = new Size(37, 15);
      labelAutor.TabIndex = 2;
      labelAutor.Text = "Autor";
      // 
      // labelSeiteAnzahl
      // 
      labelSeiteAnzahl.AutoSize = true;
      labelSeiteAnzahl.Location = new Point(265, 142);
      labelSeiteAnzahl.Name = "labelSeiteAnzahl";
      labelSeiteAnzahl.Size = new Size(71, 15);
      labelSeiteAnzahl.TabIndex = 3;
      labelSeiteAnzahl.Text = "Seite Anzahl";
      // 
      // labelLanguage
      // 
      labelLanguage.AutoSize = true;
      labelLanguage.Location = new Point(265, 201);
      labelLanguage.Name = "labelLanguage";
      labelLanguage.Size = new Size(49, 15);
      labelLanguage.TabIndex = 4;
      labelLanguage.Text = "Sprache";
      // 
      // labelPublishYear
      // 
      labelPublishYear.AutoSize = true;
      labelPublishYear.Location = new Point(265, 310);
      labelPublishYear.Name = "labelPublishYear";
      labelPublishYear.Size = new Size(112, 15);
      labelPublishYear.TabIndex = 5;
      labelPublishYear.Text = "Erscheinungsdatum";
      // 
      // textBoxName
      // 
      textBoxName.Location = new Point(347, 32);
      textBoxName.Name = "textBoxName";
      textBoxName.Size = new Size(258, 23);
      textBoxName.TabIndex = 6;
      // 
      // textBoxAutor
      // 
      textBoxAutor.Location = new Point(347, 82);
      textBoxAutor.Name = "textBoxAutor";
      textBoxAutor.Size = new Size(258, 23);
      textBoxAutor.TabIndex = 7;
      // 
      // textBoxSeiteAnzahl
      // 
      textBoxSeiteAnzahl.Location = new Point(347, 139);
      textBoxSeiteAnzahl.Name = "textBoxSeiteAnzahl";
      textBoxSeiteAnzahl.Size = new Size(258, 23);
      textBoxSeiteAnzahl.TabIndex = 8;
      // 
      // textBoxLanguage
      // 
      textBoxLanguage.Location = new Point(347, 193);
      textBoxLanguage.Name = "textBoxLanguage";
      textBoxLanguage.Size = new Size(258, 23);
      textBoxLanguage.TabIndex = 9;
      // 
      // textBoxNote
      // 
      textBoxNote.Location = new Point(347, 253);
      textBoxNote.Name = "textBoxNote";
      textBoxNote.Size = new Size(258, 23);
      textBoxNote.TabIndex = 10;
      // 
      // dateTimePickerErscheinung
      // 
      dateTimePickerErscheinung.CustomFormat = "dd.MM.yyyy";
      dateTimePickerErscheinung.Format = DateTimePickerFormat.Custom;
      dateTimePickerErscheinung.Location = new Point(405, 304);
      dateTimePickerErscheinung.Name = "dateTimePickerErscheinung";
      dateTimePickerErscheinung.Size = new Size(200, 23);
      dateTimePickerErscheinung.TabIndex = 11;
      // 
      // labelNote
      // 
      labelNote.AutoSize = true;
      labelNote.Location = new Point(265, 253);
      labelNote.Name = "labelNote";
      labelNote.Size = new Size(33, 15);
      labelNote.TabIndex = 12;
      labelNote.Text = "Note";
      // 
      // tabControlBuch
      // 
      tabControlBuch.Controls.Add(tabPage1);
      tabControlBuch.Controls.Add(tabPageStandort);
      tabControlBuch.Controls.Add(tabPage3);
      tabControlBuch.Location = new Point(2, 360);
      tabControlBuch.Name = "tabControlBuch";
      tabControlBuch.SelectedIndex = 0;
      tabControlBuch.Size = new Size(603, 255);
      tabControlBuch.TabIndex = 13;
      // 
      // tabPage1
      // 
      tabPage1.BackColor = Color.LightGray;
      tabPage1.Controls.Add(flowLayoutPanelBestand);
      tabPage1.Controls.Add(buttonNeuBestand);
      tabPage1.Controls.Add(listViewBestand);
      tabPage1.Location = new Point(4, 24);
      tabPage1.Name = "tabPage1";
      tabPage1.Padding = new Padding(3);
      tabPage1.Size = new Size(595, 227);
      tabPage1.TabIndex = 0;
      tabPage1.Text = "Bestand";
      // 
      // flowLayoutPanelBestand
      // 
      flowLayoutPanelBestand.Location = new Point(6, 35);
      flowLayoutPanelBestand.Name = "flowLayoutPanelBestand";
      flowLayoutPanelBestand.Size = new Size(583, 177);
      flowLayoutPanelBestand.TabIndex = 16;
      // 
      // buttonNeuBestand
      // 
      buttonNeuBestand.Location = new Point(6, 6);
      buttonNeuBestand.Name = "buttonNeuBestand";
      buttonNeuBestand.Size = new Size(75, 23);
      buttonNeuBestand.TabIndex = 2;
      buttonNeuBestand.Text = "Neu";
      buttonNeuBestand.UseVisualStyleBackColor = true;
      buttonNeuBestand.Click += buttonNeuBestand_Click;
      // 
      // listViewBestand
      // 
      listViewBestand.BackColor = Color.Silver;
      listViewBestand.Columns.AddRange(new ColumnHeader[] { columnHeaderAnzahl, columnHeaderVerfugbar });
      listViewBestand.GridLines = true;
      listViewBestand.Location = new Point(6, 35);
      listViewBestand.Name = "listViewBestand";
      listViewBestand.Size = new Size(586, 177);
      listViewBestand.TabIndex = 1;
      listViewBestand.UseCompatibleStateImageBehavior = false;
      listViewBestand.View = View.Details;
      // 
      // columnHeaderAnzahl
      // 
      columnHeaderAnzahl.Text = "Gesamte - Anzahl";
      columnHeaderAnzahl.Width = 150;
      // 
      // columnHeaderVerfugbar
      // 
      columnHeaderVerfugbar.Text = "Verfugbar ?";
      columnHeaderVerfugbar.Width = 100;
      // 
      // tabPageStandort
      // 
      tabPageStandort.BackColor = Color.LightGray;
      tabPageStandort.Controls.Add(flowLayoutPanelStandort);
      tabPageStandort.Controls.Add(listViewStandort);
      tabPageStandort.Controls.Add(buttonNeuStandort);
      tabPageStandort.Location = new Point(4, 24);
      tabPageStandort.Name = "tabPageStandort";
      tabPageStandort.Padding = new Padding(3);
      tabPageStandort.Size = new Size(595, 227);
      tabPageStandort.TabIndex = 1;
      tabPageStandort.Text = "Standort";
      // 
      // flowLayoutPanelStandort
      // 
      flowLayoutPanelStandort.Location = new Point(6, 35);
      flowLayoutPanelStandort.Name = "flowLayoutPanelStandort";
      flowLayoutPanelStandort.Size = new Size(583, 186);
      flowLayoutPanelStandort.TabIndex = 16;
      // 
      // listViewStandort
      // 
      listViewStandort.BackColor = Color.Silver;
      listViewStandort.Columns.AddRange(new ColumnHeader[] { columnHeaderShelf, columnHeaderReihe, columnHeaderPosition });
      listViewStandort.GridLines = true;
      listViewStandort.Location = new Point(6, 35);
      listViewStandort.Name = "listViewStandort";
      listViewStandort.Size = new Size(583, 186);
      listViewStandort.TabIndex = 1;
      listViewStandort.UseCompatibleStateImageBehavior = false;
      listViewStandort.View = View.Details;
      // 
      // columnHeaderShelf
      // 
      columnHeaderShelf.Text = "Shelf";
      columnHeaderShelf.Width = 100;
      // 
      // columnHeaderReihe
      // 
      columnHeaderReihe.Text = "Reihe";
      columnHeaderReihe.Width = 100;
      // 
      // columnHeaderPosition
      // 
      columnHeaderPosition.Text = "Position";
      columnHeaderPosition.Width = 100;
      // 
      // buttonNeuStandort
      // 
      buttonNeuStandort.Location = new Point(6, 6);
      buttonNeuStandort.Name = "buttonNeuStandort";
      buttonNeuStandort.Size = new Size(75, 23);
      buttonNeuStandort.TabIndex = 0;
      buttonNeuStandort.Text = "Neu";
      buttonNeuStandort.UseVisualStyleBackColor = true;
      buttonNeuStandort.Click += buttonNeuStandort_Click;
      // 
      // tabPage3
      // 
      tabPage3.BackColor = Color.LightGray;
      tabPage3.Controls.Add(flowLayoutPanelReservierung);
      tabPage3.Controls.Add(buttonNeuReservierung);
      tabPage3.Location = new Point(4, 24);
      tabPage3.Name = "tabPage3";
      tabPage3.Padding = new Padding(3);
      tabPage3.Size = new Size(595, 227);
      tabPage3.TabIndex = 2;
      tabPage3.Text = "Reservierung";
      // 
      // flowLayoutPanelReservierung
      // 
      flowLayoutPanelReservierung.AutoScroll = true;
      flowLayoutPanelReservierung.Location = new Point(6, 35);
      flowLayoutPanelReservierung.Name = "flowLayoutPanelReservierung";
      flowLayoutPanelReservierung.Size = new Size(586, 186);
      flowLayoutPanelReservierung.TabIndex = 1;
      // 
      // buttonNeuReservierung
      // 
      buttonNeuReservierung.Location = new Point(6, 6);
      buttonNeuReservierung.Name = "buttonNeuReservierung";
      buttonNeuReservierung.Size = new Size(75, 23);
      buttonNeuReservierung.TabIndex = 0;
      buttonNeuReservierung.Text = "Neu";
      buttonNeuReservierung.UseVisualStyleBackColor = true;
      buttonNeuReservierung.Click += buttonNeuReservierung_Click;
      // 
      // buttonSpeichern
      // 
      buttonSpeichern.Location = new Point(405, 621);
      buttonSpeichern.Name = "buttonSpeichern";
      buttonSpeichern.Size = new Size(91, 33);
      buttonSpeichern.TabIndex = 14;
      buttonSpeichern.Text = "Speichern";
      buttonSpeichern.UseVisualStyleBackColor = true;
      buttonSpeichern.Click += buttonSpeichern_Click;
      // 
      // buttonAbbrechen
      // 
      buttonAbbrechen.Location = new Point(512, 622);
      buttonAbbrechen.Name = "buttonAbbrechen";
      buttonAbbrechen.Size = new Size(89, 32);
      buttonAbbrechen.TabIndex = 15;
      buttonAbbrechen.Text = "Abbrechen";
      buttonAbbrechen.UseVisualStyleBackColor = true;
      buttonAbbrechen.Click += buttonAbbrechen_Click;
      // 
      // labelIdNumber
      // 
      labelIdNumber.AutoSize = true;
      labelIdNumber.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
      labelIdNumber.Location = new Point(12, 9);
      labelIdNumber.Name = "labelIdNumber";
      labelIdNumber.Size = new Size(0, 20);
      labelIdNumber.TabIndex = 16;
      // 
      // BuchDetail
      // 
      AcceptButton = buttonSpeichern;
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.LightGray;
      CancelButton = buttonAbbrechen;
      ClientSize = new Size(617, 661);
      Controls.Add(labelIdNumber);
      Controls.Add(buttonAbbrechen);
      Controls.Add(buttonSpeichern);
      Controls.Add(tabControlBuch);
      Controls.Add(labelNote);
      Controls.Add(dateTimePickerErscheinung);
      Controls.Add(textBoxNote);
      Controls.Add(textBoxLanguage);
      Controls.Add(textBoxSeiteAnzahl);
      Controls.Add(textBoxAutor);
      Controls.Add(textBoxName);
      Controls.Add(labelPublishYear);
      Controls.Add(labelLanguage);
      Controls.Add(labelSeiteAnzahl);
      Controls.Add(labelAutor);
      Controls.Add(labelName);
      Controls.Add(pictureBoxBuch);
      Name = "BuchDetail";
      StartPosition = FormStartPosition.CenterParent;
      Text = "BuchDetail";
      ((System.ComponentModel.ISupportInitialize)pictureBoxBuch).EndInit();
      tabControlBuch.ResumeLayout(false);
      tabPage1.ResumeLayout(false);
      tabPageStandort.ResumeLayout(false);
      tabPage3.ResumeLayout(false);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private PictureBox pictureBoxBuch;
    private Label labelName;
    private Label labelAutor;
    private Label labelSeiteAnzahl;
    private Label labelLanguage;
    private Label labelPublishYear;
    private TextBox textBoxName;
    private TextBox textBoxAutor;
    private TextBox textBoxSeiteAnzahl;
    private TextBox textBoxLanguage;
    private TextBox textBoxNote;
    private DateTimePicker dateTimePickerErscheinung;
    private Label labelNote;
    private TabControl tabControlBuch;
    private TabPage tabPage1;
    private TabPage tabPageStandort;
    private TabPage tabPage3;
    private ListView listViewBestand;
    private ColumnHeader columnHeaderAnzahl;
    private ColumnHeader columnHeaderVerfugbar;
    private Button buttonNeuStandort;
    private ListView listViewStandort;
    private ColumnHeader columnHeaderShelf;
    private ColumnHeader columnHeaderReihe;
    private ColumnHeader columnHeaderPosition;
    private Button buttonNeuReservierung;
    private FlowLayoutPanel flowLayoutPanelReservierung;
    private Button buttonNeuBestand;
    private Button buttonSpeichern;
    private Button buttonAbbrechen;
    private FlowLayoutPanel flowLayoutPanelBestand;
    private FlowLayoutPanel flowLayoutPanelStandort;
    private Label labelIdNumber;
  }
}