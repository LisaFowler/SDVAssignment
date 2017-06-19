using System;
using System.Windows.Forms;
using System.Collections.Generic;

//Developed by Lisa Fowler using code originally developed by Matthias Otto
//Date - 19/06/2017

namespace SandwichWinForm
{
    public partial class frmChef : Form
    {
        private clsChef _Chef;       

        private static Dictionary<string, frmChef> _ChefFormList =
            new Dictionary<string, frmChef>();

        private frmChef()
        {
            InitializeComponent();
        }
         
        public static void Run(string prChefName)
        {
            frmChef lcChefForm;
            if (string.IsNullOrEmpty(prChefName) ||
                !_ChefFormList.TryGetValue(prChefName, out lcChefForm))
            {
                lcChefForm = new frmChef();
                if (string.IsNullOrEmpty(prChefName))
                    lcChefForm.SetDetails(new clsChef());

                else
                {
                    _ChefFormList.Add(prChefName, lcChefForm);
                    lcChefForm.refreshFormFromDB(prChefName);
                }
            }
            else
            {
                lcChefForm.Show();
                lcChefForm.Activate();
            }
        }

        private async void refreshFormFromDB(string prChefName)
        {
            try
            {
                SetDetails(await ServiceClient.GetChefNamesAsync(prChefName));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void updateTitle(string prSandwichName)
        {
            if (!string.IsNullOrEmpty(prSandwichName))
                Text = "Chef Details, " + prSandwichName;
        }

        private void UpdateDisplay()
        {
            lstSandwich.DataSource = null;
            if (_Chef.SandwichList != null)
                lstSandwich.DataSource = _Chef.SandwichList;
        }

        public void UpdateForm()
        {
            txtName.Text = _Chef.ChefName;
            txtSpecialty.Text = _Chef.Specialty;                      
        }

        public void SetDetails(clsChef prChef)
        {
            _Chef = prChef;
            txtName.Enabled = string.IsNullOrEmpty(_Chef.ChefName);
            UpdateForm();
            UpdateDisplay();            
            Show();
        }

        private void pushData()
        {
            _Chef.ChefName = txtName.Text;
            _Chef.Specialty = txtSpecialty.Text;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private void lstSandwich_DoubleClick(object sender, EventArgs e)
        {
            string lcKey;

            lcKey = Convert.ToString(lstSandwich.SelectedItem);
            if (lcKey != null)
                try
                {
                    frmChef.Run(lstSandwich.SelectedItem as string);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "This should never occur");
                }           
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int lcIndex = lstSandwich.SelectedIndex;

            if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Deleting Sandwich", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(await ServiceClient.DeleteSandwichAsync(lstSandwich.SelectedItem as clsAllSandwiches));
                refreshFormFromDB(_Chef.ChefName);
                frmMain.Instance.UpdateDisplay();                
            }
        }

        private async void btnClose_Click(object sender, EventArgs e)
        {   
            if (isValid() == true)
                try
                {
                    pushData();
                    if (txtName.Enabled)
                    {
                        MessageBox.Show(await ServiceClient.InsertChefAsync(_Chef));
                        frmMain.Instance.UpdateDisplay();
                        txtName.Enabled = false;
                    }
                else
                    MessageBox.Show(await ServiceClient.UpdateChefAsync(_Chef));
                Hide();
                }
                catch (Exception ex)
            {
                MessageBox.Show(ex.Message);               
            }     
        }

        private Boolean isValid()
        {            
            return true;
        }

        private void frmChef_Load(object sender, EventArgs e)
        {
            UpdateDisplay();
        }

        private async void btnClose_Click_1(object sender, EventArgs e)
        {
            if (isValid() == true)
                try
                {
                    pushData();
                    if (txtName.Enabled)
                    {
                        MessageBox.Show(await ServiceClient.InsertChefAsync(_Chef));
                        frmMain.Instance.UpdateDisplay();
                        txtName.Enabled = false;
                    }
                    else
                        MessageBox.Show(await ServiceClient.UpdateChefAsync(_Chef));
                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }
    }
}