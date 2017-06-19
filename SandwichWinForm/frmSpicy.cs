
//Developed by Lisa Fowler using code originally developed by Matthias Otto
//Date - 19/06/2017

namespace SandwichWinForm
{
    public partial class frmSpicy : SandwichWinForm.frmSandwich
    {
        private static readonly frmSpicy Instance = new frmSpicy();
        public frmSpicy()
        {
            InitializeComponent();
        }
       public static void Run(clsAllSandwiches prSpicy) 
        {
            Instance.SetDetails(prSpicy);
        }

        protected override void updateForm()
        {
            base.updateForm();
            clsAllSandwiches lcSandwich = (clsAllSandwiches)_Sandwich;
            txtFilling2.Text = _Sandwich.Filling2;
            txtFilling3.Text = _Sandwich.Filling3;            
        }

        protected override void pushData()
        {
            base.pushData();
            clsAllSandwiches lcSandwich = (clsAllSandwiches)_Sandwich; 
            lcSandwich.Filling2 = txtFilling2.Text;
            lcSandwich.Filling3 = txtFilling3.Text;         
        }

    }
}
