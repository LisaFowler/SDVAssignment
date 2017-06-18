using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SandwichWinForm
{
    public partial class frmChef : Form
    {
        private clsChef _Chef;
        //private string _ChefDisplay;    
        //private clsSandwichList _SandwichList;

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
            //txtPhone.Text = _Chef.Phone;
           // _SandwichList = _Chef.SandwichList;

            //frmMain.Instance.GalleryNameChanged += new frmMain.Notify(updateTitle);
            //updateTitle(_Artist.ArtistList.GalleryName);
        }

        public void SetDetails(clsChef prChef)
        {
            _Chef = prChef;
            txtName.Enabled = string.IsNullOrEmpty(_Chef.ChefName);
            UpdateForm();
            UpdateDisplay();
            //frmMain.Instance.SandwichNameChanged += new frmMain.Notify(updateTitle);
            //updateTitle(_Chef.ChefList.SandwichName);
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

            /*   string lcReply = new InputBox(clsSandwich.FACTORY_PROMPT).Answer;
                 if (!string.IsNullOrEmpty(lcReply))
                 {
                     clsSandwiches lcSandwich = clsSandwiches.NewSandwich(lcReply[0]);
                     if (lcSandwich != null)
                     {
                         if (txtName.Enabled)
                         {
                             pushData();
                             await ServiceClient.InsertChefAsync(_Chef);
                             txtName.Enabled = false;
                         }
                         lcSandwich.ChefName = _Chef.Name;
                         frmSandwich.DispatchSandwichFrom(lcSandwich);
                         if (!string.IsNullOrEmpty(lcSandwich.SandwichName))
                         {
                             refreshFormFromDB(_Chef.Name);
                             frmMain.Instance.UpdateDisplay();*/

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


            /* try
             {
                 _SandwichList.EditWork(lstSandwich.SelectedIndex);
                 UpdateDisplay();
                 frmMain.Instance.UpdateDisplay();
             }
             catch (Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }*/
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int lcIndex = lstSandwich.SelectedIndex;

            if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Deleting Sandwich", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                MessageBox.Show(await ServiceClient.DeleteSandwichAsync(lstSandwich.SelectedItem as clsAllSandwiches));
                refreshFormFromDB(_Chef.ChefName);
                frmMain.Instance.UpdateDisplay();

                //_SandwichList.RemoveAt(lcIndex);
                //UpdateDisplay();
                //frmMain.Instance.UpdateDisplay();
            }
        }

        /*private async void btnClose_Click(object sender, EventArgs e)
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

        }*/

        private Boolean isValid()
        {
            /*if (txtName.Enabled && txtName.Text != "")
                if (_Chef.IsDuplicate(txtName.Text))
                {
                    MessageBox.Show("Chef with that name already exists!", "Error adding Chef");
                    return false;
                }
                else*/
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