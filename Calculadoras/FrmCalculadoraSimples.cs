using System.Data;

namespace Calculadoras
{
    public partial class FrmCalculadoraSimples : Form
    {
        private string accValue = "";
        DataTable Calc = new DataTable();

        public FrmCalculadoraSimples()
        {
            InitializeComponent();
            this.txbDisplay.KeyPress += new KeyPressEventHandler(txbDisplay_KeyPress);
        }

        private void FrmCalculadoraSimples_Load(object sender, EventArgs e)
        {
            txbDisplay.Clear();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            ConcatenateNumber(0);

        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            ConcatenateNumber(1);
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            ConcatenateNumber(2);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            ConcatenateNumber(3);
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            ConcatenateNumber(4);
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            ConcatenateNumber(5);
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            ConcatenateNumber(6);
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            ConcatenateNumber(7);
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            ConcatenateNumber(8);
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            ConcatenateNumber(9);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Operation("+");
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            Operation("-");
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            Operation("*");
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            Operation("/");
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            CalculateResult();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
            txbDisplay.Clear();
            accValue = "";
            txbDisplay.Focus();
        }

        private void ConcatenateNumber(int number)
        {
            txbDisplay.Text += number.ToString();
            txbDisplay.Focus();
        }

        private void Operation(string signal)
        {
            if (string.IsNullOrEmpty(txbDisplay.Text))
            {
                return;
            }
            accValue = txbDisplay.Text + signal;
            txbDisplay.Clear();
            txbDisplay.Focus();
        }

        private void CalculateResult()
        {
            if (string.IsNullOrEmpty(txbDisplay.Text) || accValue.IndexOfAny("+-*/".ToCharArray()) == -1)
            {
                return;
            }
            accValue += txbDisplay.Text;
            var result = Calc.Compute(accValue.Replace(",", "."), "");
            accValue = result.ToString();
            txbDisplay.Text = accValue;
            txbDisplay.Focus();
        }

        private void txbDisplay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("+-*/".Contains(e.KeyChar))
            {
                Operation(e.KeyChar.ToString());
            }
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void FrmCalculadoraSimples_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculateResult();
            }
        }

        private void txbDisplay_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CalculateResult();
            }
            else if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Delete)
            {
                ClearData();
            }
        }
    }
}
