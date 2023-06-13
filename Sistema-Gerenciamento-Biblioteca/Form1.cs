namespace Sistema_Gerenciamento_Biblioteca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void entrar_home_Click(object sender, EventArgs e)
        {
            Entrar form_entrar = new Entrar();
            form_entrar.Show();

            this.Hide();
        }

        private void cadastro_home_Click(object sender, EventArgs e)
        {
            Cadastro form_cadastro = new Cadastro();
            form_cadastro.Show();

            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}