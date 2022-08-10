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
            Hide();
            imcCalc.Show();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            var calcSimples = new FrmCalculadoraSimples();
            this.Hide();
            calcSimples.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(1);
        }
    }
}
