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
            imcCalc.ShowDialog();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            var calcSimples = new FrmCalculadoraSimples();
            calcSimples.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(1);
        }
    }
}
