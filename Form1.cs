namespace BibIioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public struct Datos
        {
            public string Usuario;
            public string Nombre;
            public string Apellido;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos info;
            info.Usuario = txtUsuario.Text;
            info.Nombre = txtNombre.Text;
            info.Apellido = txtApellido.Text;

            Form2 f = new Form2(info);
            f.ShowDialog();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}