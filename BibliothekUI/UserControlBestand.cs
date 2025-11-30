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

  public partial class UserControlBestand : UserControl {
  // connect this control with the Bestand class
    public Bestand bestandZustand;
    public event Action CloseRequested; // close to panel

    public UserControlBestand() {
      InitializeComponent();
      bestandZustand = new Bestand(); // create a new Bestand instance when initialized

    }

    private void buttonCancel_Click(object sender, EventArgs e) {
      bestandZustand.Anzahl = -1; // mark a canceled
      CloseRequested?.Invoke(); // event is active
    }

    private void buttonAdd_Click(object sender, EventArgs e) {
      bestandZustand.Anzahl = Convert.ToInt32(numericUpDownBestand.Value);

      CloseRequested?.Invoke(); // event is active

    }
  }
}
