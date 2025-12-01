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
  public partial class BuchDetail : Form {
    // If this form is used both for creating and editing books,
    // it's better to keep it null initially.
    Buch buch;

    // User controls for the child sections

    UserControlBestand bestand;
    UserControlStandort standort;
     UserControlReservierung reservierung;

    public BuchDetail() {
      InitializeComponent();
      //buch = new Buch();  // do not create a new object here; it will be created on save if needed
      flowLayoutPanelBestand.Visible = false;
      flowLayoutPanelStandort.Visible = false;
      
    }
    // Called when editing an existing book selected from the main list
    public Buch Buch { get => this.buch;}  // yukarida biz buch'u private olarak tanimladik. ondan erisim property uzerinden

    // Assign the book coming from MenuBibliothek so we edit the same instance
    public BuchDetail(Buch buchDoubleClick) : this(){
    
      this.buch = buchDoubleClick;
      this.labelIdNumber.Text = buchDoubleClick.Number.ToString("0####");
      this.textBoxName.Text = this.buch.Name;
      this.textBoxAutor.Text = this.buch.Autor;
      this.textBoxSeiteAnzahl.Text = this.buch.SeiteAnzahl;
      this.textBoxLanguage.Text = this.buch.Sprache;
      this.textBoxNote.Text = this.buch.Note;
      //this.dateTimePickerErscheinung.Value = this.buch.ErscheinungsDatum.ToDateTime(new TimeOnly(0,0));
      this.dateTimePickerErscheinung.Value = this.buch.ErscheinungsDatum.Value;

      // tetkrardan xml den bilgileri yazdirma 
      ListViewItem item;
      foreach (var element in this.buch.bestandList) {
       item =  new ListViewItem();
        item.Text = Convert.ToString(element.Anzahl);
        item.SubItems.Add(element.Verfugbar);
        this.listViewBestand.Items.Add(item);
      }
      
      foreach (var element in this.buch.standortList)
      {
        item = new ListViewItem();
        item.Text = Convert.ToString(element.Shelf);
        item.SubItems.Add(element.Reihe);
        item.SubItems.Add(element.Position);
        this.listViewStandort.Items.Add(item);
      }
      
      foreach (Reservierung element in this.buch.reservierungList)
      {
        
        reservierung = new UserControlReservierung(element);

        flowLayoutPanelReservierung.Controls.Add(reservierung);
      }






    }
    private Buch AddBuchInfo() {
      // Copy UI values into the Buch instance
      this.buch.Name = textBoxName.Text;
      this.buch.Autor = textBoxAutor.Text;
      this.buch.SeiteAnzahl = textBoxSeiteAnzahl.Text;
      this.buch.Sprache = textBoxLanguage.Text;
      this.buch.Note = textBoxNote.Text;
      //this.buch.ErscheinungsDatum = DateOnly.FromDateTime(dateTimePickerErscheinung.Value);
      this.buch.ErscheinungsDatum = dateTimePickerErscheinung.Value;

      return this.buch;
    }

    private void buttonNeuBestand_Click(object sender, EventArgs e) {

      flowLayoutPanelBestand.Visible = true;
      flowLayoutPanelBestand.Controls.Clear(); // old page is gone.

      bestand = new UserControlBestand();

      flowLayoutPanelBestand.Controls.Add(bestand);  // user control is in the panel

      // add a new listener to the event; () means no parameters
      // event fires when "Add" or "Cancel" is clicked inside the user control

      bestand.CloseRequested += () => {
        // if -1 comes from the user control (Cancel), do not add it to the list
        if (bestand.bestandZustand.Anzahl != -1)
          ListBestand(bestand);
        flowLayoutPanelBestand.Visible = false;
      };

    }
    private void ListStandort(UserControlStandort userStandort) {
      ListViewItem item = new ListViewItem();

      item.Text = userStandort.standort.Shelf;
      item.SubItems.Add(userStandort.standort.Reihe);
      item.SubItems.Add(userStandort.standort.Position);

      ListViewItem(item, listViewStandort);

    }
    private void ListBestand(UserControlBestand bestand) {

      ListViewItem item = new ListViewItem();

      item.Text = Convert.ToString(bestand.bestandZustand.Anzahl);
      item.SubItems.Add(bestand.bestandZustand.Verfugbar);

      ListViewItem(item, listViewBestand);

    }

    // save the information of Buch
    private void buttonSpeichern_Click(object sender, EventArgs e) {
      // Create the Buch object here only if it doesn't exist yet (new book case)

      

      if (buch == null)
      {
        buch = new Buch();  /// !!!!!!!!!!!!!!!!!
        
      }
      // Fill the Buch instance with values from the form
      AddBuchInfo();
      // If the user never opened a section, do not add anything to that list
      if (reservierung != null)
        {
          this.buch.reservierungList.Add(reservierung.Reservierung);
        }
        if (bestand != null)
        {
          this.buch.bestandList.Add(bestand.bestandZustand);

        }
        if (standort != null)
        {

          this.buch.standortList.Add(standort.standort);
        }
        
        this.DialogResult = DialogResult.OK;
          
        this.Close();
    }
    private void buttonNeuStandort_Click(object sender, EventArgs e) {

      flowLayoutPanelStandort.Visible = true;
      flowLayoutPanelStandort.Controls.Clear(); // old page is gone.

      standort = new UserControlStandort();
      // place the user control inside the panel
      flowLayoutPanelStandort.Controls.Add(standort);

      // add a new listener to the event; () means no parameters
      // event fires when "Add" or "Cancel" is clicked inside the user control
      standort.CloseRequested += () => {

        // if Cancel was clicked, Shelf will be null → do not add to the list
        if (standort.standort.Shelf != null)
        {
          ListStandort(standort);
        }

        flowLayoutPanelStandort.Visible = false;
      };

    }
    private void ListViewItem(ListViewItem item, ListView list) {

      list.Items.Add(item);

      // ensure there is only one row in this list:
      // if user changes the value more than once, keep only the latest entry
      if (list.Items.Count > 1)
      {
        list.Items.Clear();
        list.Items.Add(item);
      }
    }

    private void buttonNeuReservierung_Click(object sender, EventArgs e) {
      reservierung = new UserControlReservierung();

      flowLayoutPanelReservierung.Controls.Add(reservierung);

    }

    private void buttonAbbrechen_Click(object sender, EventArgs e) {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }
  }

}
