using BibliothekBackEnd;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliothekUI {
  public partial class UserControlStandort : UserControl {

    public Standort standort;
    public event Action CloseRequested; // close to panel
    public UserControlStandort() {
      InitializeComponent();
      standort = new Standort();
    }

    

    private void buttonAdd_Click(object sender, EventArgs e) {

      this.standort.Shelf = textBoxShelf.Text;


      this.standort.Reihe = textBoxReihe.Text;
      this.standort.Position = textBoxPosition.Text;

      CloseRequested?.Invoke(); // event is active
    }

    private void buttonAbbrechen_Click(object sender, EventArgs e) {

      // mark a canceled 
      this.standort.Shelf = null;
      

      CloseRequested?.Invoke(); // event is active
    }
  }
}
