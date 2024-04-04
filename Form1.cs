namespace RepasoCsharpEjercicio36
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton_Click(object sender, EventArgs e)
        {
            string cadena = textBox.Text;


            if (cadena.Length >= 10 && cadena.Length <= 20)
            {

                MessageBox.Show("La cadena ingresada es válida: " + cadena);
                textBox.Text = "";
            }
            else
            {

                MessageBox.Show("La cadena debe tener entre 10 y 20 caracteres.");
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
