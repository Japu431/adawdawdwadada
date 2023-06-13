using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Sistema_Gerenciamento_Biblioteca
{

    public partial class Entrar : Form
    {


        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost; username=root; password=admin;database=db_biblioteca";

        public Entrar()
        {
            InitializeComponent();
        }

        private void Entrar_Load(object sender, EventArgs e)
        {

        }

        private void Tela_Login_Entrar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_source);

                string sql = $"SELECT * FROM USUARIOS WHERE matricula = {campo_emailRA.Text} OR email = {campo_emailRA.Text}";
                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);


                if (campo_emailRA.Text == "" || campo_password.Text == "")
                {
                    MessageBox.Show("Campos vazios não podem existir!");
                    return;
                }
                

                    if (radio_funcionarios.Checked)
                    {
                        Admin adm = new Admin();
                        adm.Show();
                        this.Close();

                    }
                    else
                    {
                        UsuarioForm formUser = new UsuarioForm();
                        formUser.Show();

                        this.Close();
                    }
                



            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro: {erro}");


            }
            finally
            {

            }


        }
    }
}
