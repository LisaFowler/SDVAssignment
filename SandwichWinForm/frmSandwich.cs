using System;
using System.Windows.Forms;

//Developed by Lisa Fowler using code originally developed by Matthias Otto
//Date - 19/06/2017

namespace SandwichWinForm
{
    public partial class frmSandwich : Form
    {
        protected clsAllSandwiches _Sandwich;

        public frmSandwich()
        { 
            InitializeComponent();
        }

        public void SetDetails(clsAllSandwiches prSandwich)
        {
            _Sandwich = prSandwich;
            updateForm();
            ShowDialog();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (isValid())
            {
                pushData();
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected virtual bool isValid()
        {
            return true;
        }

        protected virtual void updateForm()
        {
            txtName.Text = _Sandwich.SandwichName;
            txtChef.Text = _Sandwich.ChefName;
            txtFilling.Text = _Sandwich.Filling;
            txtType.Text = _Sandwich.Type;
            txtPrice.Text = _Sandwich.Price.ToString();
        }

        protected virtual void pushData()
        {
            _Sandwich.SandwichName = txtName.Text;
            _Sandwich.ChefName = txtChef.Text;
            _Sandwich.Filling = txtFilling.Text;
            _Sandwich.Type = txtType.Text;
            _Sandwich.Price = decimal.Parse(txtPrice.Text);
        }

    }
}
