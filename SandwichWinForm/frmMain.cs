using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SandwichWinForm
{
    public sealed partial class frmMain : Form
    {   
        private static readonly frmMain _Instance = new frmMain();
       
        public frmMain()
        {
            InitializeComponent();
        }        

        public async void UpdateDisplay()
        {
            try
            {
                lstChef.DataSource = null;
                lstChef.DataSource = await ServiceClient.GetChefNamesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error finding chef list");
            }                     
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //frmArtist.Run(new clsArtist(_ArtistList));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error adding new chef");
            }
        }

        private void lstChef_DoubleClick(object sender, EventArgs e)
        {
            /*string lcKey;

            lcKey = Convert.ToString(lstArtists.SelectedItem);
            if (lcKey != null)
                try
                {
                    frmArtist.Run(_ArtistList[lcKey]);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "This should never occur");
                }*/
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {           
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           /* string lcKey;

            lcKey = Convert.ToString(lstArtists.SelectedItem);
            if (lcKey != null && MessageBox.Show("Are you sure?", "Deleting artist", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                try
                {
                    _ArtistList.Remove(lcKey);
                    lstArtists.ClearSelected();
                    UpdateDisplay();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error deleting artist");
                }*/
        }

        private void frmMain_Load(object sender, EventArgs e)
        {            
            UpdateDisplay();            
        }        
    }
}