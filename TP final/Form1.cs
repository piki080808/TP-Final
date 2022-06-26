namespace TP_final
{
    public partial class Form1 : Form
    {
        double Numero1 = 0, Numero2 = 0;
        char Operador;

        public Form1()
        {
            InitializeComponent();
        }

        private void agregarNumero(object sender, EventArgs e) 
        {
            var boton = ((Button)sender);

            if (tbResultado.Text == "0")
                tbResultado.Text = "";//si el resultado es igual a 0 lo vacia y a 
           
            tbResultado.Text += boton.Text;//continuacion agrega un numero       
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            Numero2 = Convert.ToDouble(tbResultado.Text);

            if (Operador == '+')
            {
                tbResultado.Text = (Numero1 + Numero2).ToString();
                Numero1 = Convert.ToDouble(tbResultado.Text);
            }
            else if (Operador == '-')  
            {
                tbResultado.Text = (Numero1 - Numero2).ToString();
                Numero1 = Convert.ToDouble(tbResultado.Text);
            }
            else if (Operador == 'X')
            {
                tbResultado.Text = (Numero1 * Numero2).ToString();
                Numero1 = Convert.ToDouble(tbResultado.Text);
            }
            else if (Operador == '/')
            {
                tbResultado.Text = (Numero1 / Numero2).ToString();
                Numero1 = Convert.ToDouble(tbResultado.Text);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (tbResultado.Text.Length >1)
            {
                tbResultado.Text = tbResultado.Text.Substring(0, tbResultado.Text.Length - 1);
            }
            else
            {
                tbResultado.Text = "0";
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            Numero1 = 0;
            Numero2 = 0;
            Operador = '\0';
            tbResultado.Text = "0";

        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!tbResultado.Text.Contains("."))
            {
                tbResultado.Text += ",";
            }
        }

        private void btnSigno_Click(object sender, EventArgs e)
        {
            Numero1 = Convert.ToDouble(tbResultado.Text);
            Numero1 *= -1;
            tbResultado.Text = Numero1.ToString();
        }

        private void clickoperador(object sender, EventArgs e) 
        {
            var boton = ((Button)sender);

            Numero1 = Convert.ToDouble(tbResultado.Text);
            Operador = Convert.ToChar(boton.Tag);

            if (Operador == '²')
            {
                Numero1 = Math.Pow(Numero1, 2);
                tbResultado.Text = Numero1.ToString();
            }
            else if (Operador == '√')
            {
                Numero1 = Math.Sqrt(Numero1);
                tbResultado.Text = Numero1.ToString();
            }
            else
            {
                 tbResultado.Text = "";
            }
           
        }
    }
} 