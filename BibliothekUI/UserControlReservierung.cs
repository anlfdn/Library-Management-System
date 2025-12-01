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
  public partial class UserControlReservierung : UserControl {
    // Do not create a Reservierung instance at startup.
    // It will be created later when needed.
     Reservierung reservierung;


    public UserControlReservierung() {
      InitializeComponent();
    }
    public UserControlReservierung(Reservierung reserve) : this() {
      this.textBoxVorname.Text = reserve.Vorname;
      this.textBoxNachname.Text = reserve.Nachname;
      this.dateTimePickerAusleihdatum.Value = reserve.AusleihDatum;
      this.labelRestTage.Text = Convert.ToString(progressBarChanged());
    }

    // BuchDetail needs to access the Reservierung instance through this property.
    public Reservierung Reservierung {
      get {
        if (reservierung == null) reservierung = new Reservierung(this.textBoxVorname.Text, this.textBoxNachname.Text,
        this.dateTimePickerAusleihdatum.Value, progressBarChanged());

        return reservierung;

      }
     
    }
    private void dateTimePickerAusleihdatum_ValueChanged(object sender, EventArgs e) {
    
    }

    public int progressBarChanged() {

      // DateOnly.FromDateTime returns only the date (time is discarded).

      DateTime startDate = this.dateTimePickerAusleihdatum.Value;

      // / max limit is 30 days
      var endDatum = startDate.AddDays(30);

      // calculate remaining days
      TimeSpan differenzDay = endDatum - DateTime.Today;
      int restDay = Convert.ToInt32(differenzDay.Days);

      // update label after the button click
      //this.labelRestTage.Text = $"End Datum ist {endDatum.ToString("dd.MM.yyyy")}";

      return restDay;
       

       
        
    }
  }
}
