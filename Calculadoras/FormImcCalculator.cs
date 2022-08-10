namespace Calculadoras
{
    public partial class FormImcCalculator : Form
    {
        public FormImcCalculator()
        {
            InitializeComponent();
        }

        private void FormImcCalculator_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double weight, height, imc;
            string resultado;
            weight = Convert.ToDouble(txbWeight.Text);
            height = Convert.ToDouble(txbHeight.Text);
            double heightMeter = height / 100;
            (resultado, imc) = CalculateImc(weight, heightMeter);
            lblGenericResult.Text = $"{resultado}\nSeu IMC: {imc}";
        }

        private (string, double) CalculateImc(double weight, double height)
        {
            double imc = weight / (height * height);

            var resultado = imc switch
            {
                < 20 => "Abaixo do peso",
                >= 20 and < 25 => "Peso normal",
                >= 25 and < 30 => "Sobre peso",
                >= 30 and < 40 => "Obeso",
                _ => "Obeso mórbido"
            };

            return (resultado, imc);
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txbWeight.Text = String.Empty;
            txbHeight.Clear();
            lblGenericResult.Text = "";
            txbWeight.Focus();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}