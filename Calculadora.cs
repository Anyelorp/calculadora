namespace calculadora_2
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operador;
        public Calculadora()
        {
            InitializeComponent();
        }
        Clases.ClsSuma obj = new Clases.ClsSuma();
        Clases.ClsResta obj2 = new Clases.ClsResta();
        Clases.ClsMultiplicar obj3 = new Clases.ClsMultiplicar();
        Clases.ClsDivision obj4 = new Clases.ClsDivision();

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnN1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void btnN2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void btnN3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btnN4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void btnN5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btnN6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btnN8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btnN1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void btnN1_Click_2(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void btnN2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void btnN3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void btnN4_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void btnN5_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void btnN6_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void btnN8_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }
      

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(textBox1.Text);
            textBox1.Clear();
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(textBox1.Text);

            double sum;
            double Res;
            double Mul;
            double Div;

            switch (operador)
            {
                case "+":
                    sum = obj.Sumar((primero), (segundo));
                    textBox1.Text = sum.ToString();
                    break;
                case "-":
                    Res = obj2.Restar((primero), (segundo));
                    textBox1.Text = Res.ToString();
                    break;
                case "*":
                    Mul = obj3.Multiplicar((primero), (segundo));
                    textBox1.Text = Mul.ToString();
                    break;
                case "/":
                    Div = obj4.Division((primero), (segundo));
                    textBox1.Text = Div.ToString();
                    break;

            }

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
