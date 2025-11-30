namespace BibliothekUI {
  partial class UserControlStandort {
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
      label1 = new Label();
      label2 = new Label();
      label3 = new Label();
      textBoxShelf = new TextBox();
      textBoxReihe = new TextBox();
      textBoxPosition = new TextBox();
      buttonAdd = new Button();
      buttonAbbrechen = new Button();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(28, 60);
      label1.Name = "label1";
      label1.Size = new Size(33, 15);
      label1.TabIndex = 0;
      label1.Text = "Shelf";
      // 
      // label2
      // 
      label2.AutoSize = true;
      label2.Location = new Point(212, 63);
      label2.Name = "label2";
      label2.Size = new Size(36, 15);
      label2.TabIndex = 1;
      label2.Text = "Reihe";
      // 
      // label3
      // 
      label3.AutoSize = true;
      label3.Location = new Point(402, 65);
      label3.Name = "label3";
      label3.Size = new Size(50, 15);
      label3.TabIndex = 2;
      label3.Text = "Position";
      // 
      // textBoxShelf
      // 
      textBoxShelf.Location = new Point(67, 57);
      textBoxShelf.Name = "textBoxShelf";
      textBoxShelf.Size = new Size(100, 23);
      textBoxShelf.TabIndex = 3;
      // 
      // textBoxReihe
      // 
      textBoxReihe.Location = new Point(254, 60);
      textBoxReihe.Name = "textBoxReihe";
      textBoxReihe.Size = new Size(100, 23);
      textBoxReihe.TabIndex = 4;
      // 
      // textBoxPosition
      // 
      textBoxPosition.Location = new Point(470, 60);
      textBoxPosition.Name = "textBoxPosition";
      textBoxPosition.Size = new Size(100, 23);
      textBoxPosition.TabIndex = 5;
      // 
      // buttonAdd
      // 
      buttonAdd.Location = new Point(173, 114);
      buttonAdd.Name = "buttonAdd";
      buttonAdd.Size = new Size(75, 23);
      buttonAdd.TabIndex = 6;
      buttonAdd.Text = "Add";
      buttonAdd.UseVisualStyleBackColor = true;
      buttonAdd.Click += buttonAdd_Click;
      // 
      // buttonAbbrechen
      // 
      buttonAbbrechen.Location = new Point(350, 114);
      buttonAbbrechen.Name = "buttonAbbrechen";
      buttonAbbrechen.Size = new Size(75, 23);
      buttonAbbrechen.TabIndex = 7;
      buttonAbbrechen.Text = "Cancel";
      buttonAbbrechen.UseVisualStyleBackColor = true;
      buttonAbbrechen.Click += buttonAbbrechen_Click;
      // 
      // UserControlStandort
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(buttonAbbrechen);
      Controls.Add(buttonAdd);
      Controls.Add(textBoxPosition);
      Controls.Add(textBoxReihe);
      Controls.Add(textBoxShelf);
      Controls.Add(label3);
      Controls.Add(label2);
      Controls.Add(label1);
      Name = "UserControlStandort";
      Size = new Size(592, 150);
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private TextBox textBoxShelf;
    private TextBox textBoxReihe;
    private TextBox textBoxPosition;
    private Button buttonAdd;
    private Button buttonAbbrechen;
  }
}
