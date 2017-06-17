using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SandwichWinForm
{
    public partial class frmChef : Form
    {
        private clsChef _Chef;      
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
                //throw new NotImplementedException();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
            }
        }

        private void updateTitle(string prSandwichName)
        {
            if (!string.IsNullOrEmpty(prSandwichName))
                Text = "Chef Details - " + prSandwichName;
        }



        private void UpdateDisplay()
        {
        }

        public void UpdateForm()
        {
            txtName.Text = _Chef.Name;
            txtSpecialty.Text = _Chef.Specialty;
            //txtPhone.Text = _Chef.Phone;
           // _SandwichList = _Chef.SandwichList;

            //frmMain.Instance.GalleryNameChanged += new frmMain.Notify(updateTitle);
            //updateTitle(_Artist.ArtistList.GalleryName);
        }

        public void SetDetails(clsChef prChef)
        {
            _Chef = prChef;
            txtName.Enabled = string.IsNullOrEmpty(_Chef.Name);
            UpdateForm();
           // UpdateDisplay();
            //frmMain.Instance.SandwichNameChanged += new frmMain.Notify(updateTitle);
            //updateTitle(_Chef.ChefList.SandwichName);
            Show();
        }

        private void pushData()
        {
            //_Chef.Name = txtName.Text;
           // _Chef.Specialty = txtChef.Text;
          //  _Chef.Phone = txtPhone.Text;
            //_WorksList.SortOrder = _SortOrder; // no longer required, updated with each rbByDate_CheckedChanged
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           // string lcReply = new InputBox(clsSandwich.FACTORY_PROMPT).Answer;
          //  if (!string.IsNullOrEmpty(lcReply))
            {
           //     _SandichList.AddWork(lcReply[0]);
           //     UpdateDisplay();
            //    frmMain.Instance.UpdateDisplay();
            }
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
           /* int lcIndex = lstSandwich.SelectedIndex;

            if (lcIndex >= 0 && MessageBox.Show("Are you sure?", "Deleting work", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                _SandwichList.RemoveAt(lcIndex);
                UpdateDisplay();
                frmMain.Instance.UpdateDisplay();
            }*/
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (isValid() == true)
                try
                {
                    pushData();
                    if (txtName.Enabled)
                    {
              //          _Chef.NewChef();
                        MessageBox.Show("Chef added!", "Success");
               //         frmMain.Instance.UpdateDisplay();
                        txtName.Enabled = false;
                    }
                    Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
        }

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
      
    }
}