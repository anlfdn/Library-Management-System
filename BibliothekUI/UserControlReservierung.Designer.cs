namespace BibliothekUI {
  partial class UserControlReservierung {
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

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      textBoxVorname = new TextBox();
      textBoxNachname = new TextBox();
      dateTimePickerAusleihdatum = new DateTimePicker();
      label1 = new Label();
      label2 = new Label();
      label3 = new Label();
      label4 = new Label();
      labelRestTage = new Label();
      SuspendLayout();
      // 
      // textBoxVorname
      // 
      textBoxVorname.Location = new Point(92, 10);
      textBoxVorname.Name = "textBoxVorname";
      textBoxVorname.Size = new Size(152, 23);
      textBoxVorname.TabIndex = 0;
      // 
      // textBoxNachname
      // 
      textBoxNachname.Location = new Point(385, 13);
      textBoxNachname.Name = "textBoxNachname";
      textBoxNachname.Size = new Size(152, 23);
      textBoxNachname.TabIndex = 1;
      // 
      // dateTimePickerAusleihdatum
      // 
      dateTimePickerAusleihdatum.CustomFormat = "dd.MM.yyyy";
      dateTimePickerAusleihdatum.Format = DateTimePickerFormat.Custom;
      dateTimePickerAusleihdatum.Location = new Point(102, 56);
      dateTimePickerAusleihdatum.Name = "dateTimePickerAusleihdatum";
      dateTimePickerAusleihdatum.Size = new Size(152, 23);
      dateTimePickerAusleihdatum.TabIndex = 2;
      dateTimePickerAusleihdatum.ValueChanged += dateTimePickerAusleihdatum_ValueChanged;
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(0, 13);
      label1.Name = "label1";
      label1.Size = new Size(54, 15);
      label1.TabIndex = 4;
      label1.Text = "Vorname";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(291, 13);
      label2.Name = "label2";
      label2.Size = new Size(65, 15);
      label2.TabIndex = 5;
      label2.Text = "Nachname";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(3, 56);
      label3.Name = "label3";
      label3.Size = new Size(81, 15);
      label3.TabIndex = 6;
      label3.Text = "Ausleihdatum";
      // 
      // label4
      // 
      label4.AutoSize = true;
      label4.Location = new Point(291, 62);
      label4.Name = "label4";
      label4.Size = new Size(52, 15);
      label4.TabIndex = 7;
      label4.Text = "Resttage";
      // 
      // labelRestTage
      // 
      labelRestTage.AutoSize = true;
      labelRestTage.BackColor = Color.RosyBrown;
      labelRestTage.Location = new Point(385, 64);
      labelRestTage.Name = "labelRestTage";
      labelRestTage.Size = new Size(0, 15);
      labelRestTage.TabIndex = 8;
      // 
      // UserControlReservierung
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      BorderStyle = BorderStyle.Fixed3D;
      Controls.Add(labelRestTage);
      Controls.Add(label4);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(label1);
      Controls.Add(dateTimePickerAusleihdatum);
      Controls.Add(textBoxNachname);
      Controls.Add(textBoxVorname);
      Name = "UserControlReservierung";
      Size = new Size(582, 96);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private TextBox textBoxVorname;
    private TextBox textBoxNachname;
    private DateTimePicker dateTimePickerAusleihdatum;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label labelRestTage;
  }
}
