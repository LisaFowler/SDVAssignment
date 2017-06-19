
//Developed by Lisa Fowler using code originally developed by Matthias Otto
//Date - 19/06/2017

namespace SandwichWinForm
{
    public partial class frmVegetarian : SandwichWinForm.frmSandwich 
    {
        private static readonly frmVegetarian Instance = new frmVegetarian();
        public frmVegetarian()
        {
            InitializeComponent();
        }
        public static void Run(clsAllSandwiches prVegetarian)
        {
            Instance.SetDetails(prVegetarian);
        }

        protected override void updateForm()
        {
            base.updateForm();
            clsAllSandwiches lcSandwich = (clsAllSandwiches)_Sandwich;            
            txtFilling2.Text = lcSandwich.Filling2;
            txtFilling3.Text = lcSandwich.Filling3;
            txtSauce.Text = lcSandwich.Sauce;
        }

        protected override void pushData()
        {
            base.pushData();
            clsAllSandwiches lcSandwich = (clsAllSandwiches)_Sandwich;
            lcSandwich.Filling2 = txtFilling2.Text;
            lcSandwich.Filling3 = txtFilling3.Text;
            lcSandwich.Sauce = txtSauce.Text;                              
        }

    }
}
