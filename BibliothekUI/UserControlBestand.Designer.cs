namespace BibliothekUI {
  partial class UserControlBestand {
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
      numericUpDownBestand = new NumericUpDown();
      buttonAdd = new Button();
      buttonCancel = new Button();
      ((System.ComponentModel.ISupportInitialize)numericUpDownBestand).BeginInit();
      SuspendLayout();
      // 
      // label1
      // 
      label1.AutoSize = true;
      label1.Location = new Point(122, 48);
      label1.Name = "label1";
      label1.Size = new Size(43, 15);
      label1.TabIndex = 0;
      label1.Text = "Anzahl";
      // 
      // numericUpDownBestand
      // 
      numericUpDownBestand.Location = new Point(220, 46);
      numericUpDownBestand.Name = "numericUpDownBestand";
      numericUpDownBestand.Size = new Size(120, 23);
      numericUpDownBestand.TabIndex = 1;
      // 
      // buttonAdd
      // 
      buttonAdd.Location = new Point(132, 92);
      buttonAdd.Name = "buttonAdd";
      buttonAdd.Size = new Size(75, 23);
      buttonAdd.TabIndex = 2;
      buttonAdd.Text = "Add";
      buttonAdd.UseVisualStyleBackColor = true;
      buttonAdd.Click += buttonAdd_Click;
      // 
      // buttonCancel
      // 
      buttonCancel.Location = new Point(282, 92);
      buttonCancel.Name = "buttonCancel";
      buttonCancel.Size = new Size(75, 23);
      buttonCancel.TabIndex = 3;
      buttonCancel.Text = "Cancel";
      buttonCancel.UseVisualStyleBackColor = true;
      buttonCancel.Click += buttonCancel_Click;
      // 
      // UserControlBestand
      // 
      AutoScaleDimensions = new SizeF(7F, 15F);
      AutoScaleMode = AutoScaleMode.Font;
      Controls.Add(buttonCancel);
      Controls.Add(buttonAdd);
      Controls.Add(numericUpDownBestand);
      Controls.Add(label1);
      Name = "UserControlBestand";
      Size = new Size(503, 150);
      ((System.ComponentModel.ISupportInitialize)numericUpDownBestand).EndInit();
      ResumeLayout(false);
      PerformLayout();
    }

    #endregion

    private Label label1;
    private NumericUpDown numericUpDownBestand;
    private Button buttonAdd;
    private Button buttonCancel;
  }
}
