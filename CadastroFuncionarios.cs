using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    internal class CadastroFuncionarios
    {
        private int id;
        private string nome = "";
        private string email = "";
        private string cpf = "";
        private string endereco = "";

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }


        
        public bool cadastrarFuncionarios()
        {
            try
            {
                using (MySqlConnection MySqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor))
                {
                    MySqlConexaoBanco.Open();

                    string insert = "INSERT INTO funcionarios (nome, email, cpf, endereco) VALUES (@Nome, @Email, @Cpf, @Endereco)";

                    using (MySqlCommand comandoSql = new MySqlCommand(insert, MySqlConexaoBanco))
                    {
                        comandoSql.Parameters.AddWithValue("@Nome", Nome);
                        comandoSql.Parameters.AddWithValue("@Email", Email);
                        comandoSql.Parameters.AddWithValue("@Cpf", Cpf);
                        comandoSql.Parameters.AddWithValue("@Endereco", Endereco);

                        comandoSql.ExecuteNonQuery();
                    }
                }

                return true;
            }
            catch (Exception ex)

            {
                //Menssagem de erro quando não é possivel cadastrar um funcionario no banco
                //Erro ligado ao banco de dados
                MessageBox.Show("Erro no banco de dados - Metodo CadastrarFuncionario" + ex.Message);
                return false;
            }
        }

        public MySqlDataReader localizarFuncionario()
        {
            try
            {
                MySqlConnection MySqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MySqlConexaoBanco.Open();

                string select = $" select id, nome, email, cpf, endereco from funcionarios where cpf = '{Cpf}';";
                MySqlCommand comandoSql = MySqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = select;

                MySqlDataReader reader = comandoSql.ExecuteReader();
                return reader;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - Método localizarFuncionario: " + ex.Message);
                return null;
            }
        }


        public bool atualizarFuncionario()
        {
            try
            {
                MySqlConnection MySqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MySqlConexaoBanco.Open();

                string update = $"update funcionarios set email = '{Email}', endereco = '{Endereco}' where id = '{Id}'; ";
                MySqlCommand comandoSql = MySqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = update;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro no banco de dados - Metodo atualizarFuncionario" + ex.Message);
                return false;
                
            }
        }

        public bool deletarFuncionario()
        {
            try
            {
                MySqlConnection MySqlConexaoBanco = new MySqlConnection(ConexaoBanco.bancoServidor);
                MySqlConexaoBanco.Open();

                string delete = $"delete from funcionarios where id = '{Id}'; ";
                MySqlCommand comandoSql = MySqlConexaoBanco.CreateCommand();
                comandoSql.CommandText = delete;

                comandoSql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro banco de dados - Metodo deletarFuncionario: " + ex.Message);
                return false;
            }
        }

    }
}