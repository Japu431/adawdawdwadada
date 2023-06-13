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
    public partial class Cadastro : Form
    {

        private MySqlConnection Conexao;
        private string data_source = "datasource=localhost; username=root; password=admin;database=db_biblioteca";

        public Cadastro()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void submit_cadastro_Click(object sender, EventArgs e)
        {


            try
            {
                Conexao = new MySqlConnection(data_source);

                // Verificação Email e Senha iguais para confirmar << 
                if (campo_email.Text != campo_email_confirm.Text)
                {
                    MessageBox.Show("Campo e-mail não são iguais!!");
                    return;

                }
                else if (campo_password.Text != campo_password_confirm.Text)
                {
                    MessageBox.Show("Campo senha não são iguais!!");
                    return;
                }
                else
                {

                    string cargo;

                    if (radio_aluno.Checked)
                    {
                        cargo = radio_aluno.Text;
                    }
                    else if (radio_professor.Checked)
                    {
                        cargo = radio_professor.Text;
                    }
                    else
                    {
                        cargo = radio_funcionarios.Text;
                    }


                    string sql = $"insert into Usuario(nome, matricula, email, senha, endereco, telefone, cargo) " +
                        $"VALUES ('{campo_nome.Text} ','{campo_matricula.Text}','{campo_email.Text}', '{campo_password.Text}', '{campo_endereco.Text}','{campo_telefone.Text}', '{cargo}');";


                    MySqlCommand comando = new MySqlCommand(sql, Conexao);
                    Conexao.Open();

                    comando.ExecuteReader();
                    MessageBox.Show("Usuário Inserido com sucesso! no Sistema!");

                    // Limpar Campos para novo cadastro!
                    campo_nome.Text = "";
                    campo_matricula.Text = "";
                    campo_password.Text = "";
                    campo_password_confirm.Text = "";
                    campo_email.Text = "";
                    campo_email_confirm.Text = "";
                    campo_telefone.Text = "";
                    campo_endereco.Text = "";


                }


            }
            catch (Exception error)
            {

                MessageBox.Show($"Erro!:  {error.Message} ");

            }
            finally
            {
                Conexao.Close();
            }


        }

        private void tela_entrar_Click(object sender, EventArgs e)
        {
            Entrar form_entrar = new Entrar();
            form_entrar.Show();

            this.Hide();
        }
    }
}
