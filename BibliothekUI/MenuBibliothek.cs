using BibliothekBackEnd;
using System.Windows.Forms;

namespace BibliothekUI
{
  public partial class MenuBibliothek : Form {

    private DataBase database;
    

    public MenuBibliothek() {
      InitializeComponent();
      this.buchToolStripMenuItem.Enabled = false;
    }


    private void getListOfBuch() {

      

      this.listViewMenu.Items.Clear();
      ListViewItem item;
      foreach (var buch in this.database.buchList) {

          item = new();
          item.Tag = buch;  // store the Buch object inside the row
        item.Text = Convert.ToString(buch.Number);
          item.SubItems.Add(buch.Name);
          item.SubItems.Add(buch.Autor);
          item.SubItems.Add(buch.SeiteAnzahl);
          item.SubItems.Add(buch.Sprache);
          item.SubItems.Add(buch.ErscheinungsDatum.ToString("dd.MM.yyyy"));
          item.SubItems.Add(buch.Note);

          this.listViewMenu.Items.Add(item);

        }
     
    }

    private void newuToolStripMenuItem_Click(object sender, EventArgs e) {  // ilk pencere geliyor kayit icin
      // open the BuchDetail form for creating a new book
      BuchDetail detailBuch = new BuchDetail();
      if (detailBuch.ShowDialog() == DialogResult.OK)
      {
        // add the created book 
        this.database.buchList.Add(detailBuch.Buch);
        // refresh UI
        getListOfBuch();

      }
      
    }

    // when double-clicking an item, load its details for editing
    private void listViewMenu_MouseDoubleClick(object sender, MouseEventArgs e) {
      if (this.listViewMenu != null) {
        ListViewItem item2 = this.listViewMenu.GetItemAt(e.X, e.Y);
        if (item2 == null) return;  // if empty area is clicked, exit

        Buch buchInfoChange = (Buch)item2.Tag;

        // retrieve the stored Buch object
        BuchDetail detailBuch = new BuchDetail(buchInfoChange);
        
        if (detailBuch.ShowDialog() == DialogResult.OK)
        {
          getListOfBuch();  // refresh UI after editing
        }
       
      }
        
    }

    private void speichernToolStripMenuItem_Click(object sender, EventArgs e) {
      if (this.database != null) {
        /// Database already contains Buch objects; just save the entire structure

        this.database.Speichern();

      }
    }

    private void neuToolStripMenuItem_Click(object sender, EventArgs e) {
      if (this.database == null) {

        SaveFileDialog dialog = new SaveFileDialog();
        dialog.Filter = "XML Dateien|*.xml";
        dialog.Title = "Daten speichern...";
        if (dialog.ShowDialog() == DialogResult.OK)
        {
          // create a new database file and enable the book menu
          this.database = new DataBase() { DateiName = dialog.FileName };
          this.database.Speichern();
          this.buchToolStripMenuItem.Enabled= true;


        }
      }
    }
  }
}
