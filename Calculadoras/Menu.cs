namespace Calculadoras
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnImc_Click(object sender, EventArgs e)
        {
            var imcCalc = new FormImcCalculator();
            imcCalc.Show();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            var calcSimples = new FrmCalculadoraSimples();
            calcSimples.Show();
        }
    }
}
