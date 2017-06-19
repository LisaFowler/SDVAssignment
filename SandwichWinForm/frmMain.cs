using System;
using System.Windows.Forms;

//Developed by Lisa Fowler using code originally developed by Matthias Otto
//Date - 19/06/2017

namespace SandwichWinForm
{
    public sealed partial class frmMain : Form
    {   
        private static readonly frmMain _Instance = new frmMain();
       
        public frmMain()
        {
            InitializeComponent();
        }

        public static frmMain Instance
        {
            get { return frmMain._Instance; }
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
                frmChef.Run(null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error adding new chef");
            }
        }

        private void lstChef_DoubleClick(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lstChef.SelectedItem);
            if (lcKey != null)
            {
                try
                {
                    frmChef.Run(lstChef.SelectedItem as string);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "This should never occur");
                }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {           
            Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lstChef.SelectedItem);
            if (lcKey != null && MessageBox.Show("Are you sure?", "Deleting chef", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                try
                {
                    _ChefList.Remove(lcKey);
                    lstChef.ClearSelected();
                    UpdateDisplay();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error deleting chef");
                }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {            
            UpdateDisplay();            
        }      
    }
}