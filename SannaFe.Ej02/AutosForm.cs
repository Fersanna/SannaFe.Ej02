namespace SannaFe.Ej02
{


    public partial class AutosForm : Form
    {
        AutoFormModel model;

        public AutosForm()
        {
            InitializeComponent();
        }



        private void MarcacomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            model = new AutoFormModel();

           UsuarioTex.Text = $"{model.Usuario}";
           FechaText.Text = model.Fecha;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            model.PrecioIngresado = this.precioText.Text;
            model.ModeloIngresado = this.modeloText.Text;
            model.AñoIngresado = this.añoText.Text;
            marcaCombo.SelectedIndex = 0;

            string mensaje = model.Validar();

            MessageBox.Show(mensaje);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var mensaje = MessageBox.Show("Se dispone a cerrar el formulario, usted esta seguro.", "Ejercicio 2", MessageBoxButtons.YesNoCancel);

            if (mensaje == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}