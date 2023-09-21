using MySql.Data.MySqlClient;
using System.ComponentModel.Design;

namespace Funcionarios
{
    public partial class Funcionarios : Form
    {
        public Funcionarios()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals("") && !txtEmail.Text.Equals("") && !txtCPF.Text.Equals("") && !txtEndereco.Text.Equals(""))
                {
                    CadastroFuncionarios cadFuncionarios = new CadastroFuncionarios();
                    cadFuncionarios.Nome = txtNome.Text;
                    cadFuncionarios.Email = txtEmail.Text;
                    cadFuncionarios.Cpf = txtCPF.Text;
                    cadFuncionarios.Endereco = txtEndereco.Text;

                    if (cadFuncionarios.cadastrarFuncionarios())
                    {
                        MessageBox.Show($"O funcionario {cadFuncionarios.Nome} foi cadastrado com sucesso!!");
                        txtNome.Clear();
                        txtEmail.Clear();
                        txtCPF.Clear();
                        txtEndereco.Clear();
                        txtNome.Focus();
                        lblId.Text = "";
                    }

                    else
                    {
                        MessageBox.Show("Não foi possivel cadastrar funcionario");

                    }


                }
                else
                {
                    MessageBox.Show("Favor preencher todos os campos corretamente");
                    txtNome.Clear();
                    txtEmail.Clear();
                    txtCPF.Clear();
                    txtEndereco.Clear();
                    txtNome.Focus();
                    lblId.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar funcionario: " + ex.Message);

            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)

        {
            try
            {
                if (!txtCPF.Text.Equals(""))
                {
                    CadastroFuncionarios cadFuncionarios = new CadastroFuncionarios();
                    cadFuncionarios.Cpf = txtCPF.Text;


                    MySqlDataReader reader = cadFuncionarios.localizarFuncionario();


                    if (reader != null)
                    {
                        if (reader.HasRows)
                        {
                            reader.Read();
                            lblId.Text = reader["id"].ToString();
                            txtNome.Text = reader["nome"].ToString();
                            txtEmail.Text = reader["email"].ToString();
                            txtEndereco.Text = reader["endereco"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Funcionario não encontrado");
                            txtCPF.Clear();
                            txtEmail.Clear();
                            txtEndereco.Clear();
                            txtNome.Clear();
                            txtCPF.Focus();
                            lblId.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Funcionario não encontrado");
                        txtCPF.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        txtNome.Clear();
                        txtCPF.Focus();
                        lblId.Text = "";
                    }

                }
                else
                {
                    MessageBox.Show("Favor preencher o campo cpf para realizar a pesquisa!");
                    txtCPF.Clear();
                    txtEmail.Clear();
                    txtEndereco.Clear();
                    txtNome.Clear();
                    txtCPF.Focus();
                    lblId.Text = "";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao encontrar funcionario" + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCPF.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNome.Clear();
            txtNome.Focus();
            lblId.Text = "";
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtNome.Text.Equals("") && !txtEmail.Text.Equals("") && !txtCPF.Text.Equals("") && !txtEndereco.Text.Equals(""))
                {
                    CadastroFuncionarios cadFuncionarios = new CadastroFuncionarios();
                    cadFuncionarios.Id = int.Parse(lblId.Text);
                    cadFuncionarios.Endereco = txtEndereco.Text;
                    cadFuncionarios.Email = txtEmail.Text;

                    if (cadFuncionarios.atualizarFuncionario())
                    {
                        MessageBox.Show("Os dados do funcionario foram atualizadas com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possivel atualizar as informaçoes do funcionario");
                        txtCPF.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        txtNome.Clear();
                        txtCPF.Focus();
                        lblId.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Favor localizar o funcionario que deseja autualizar as informaçoes");
                    txtCPF.Clear();
                    txtEmail.Clear();
                    txtEndereco.Clear();
                    txtNome.Clear();
                    txtCPF.Focus();
                    lblId.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atrualizar dados do funcionario" + ex.Message);

            }
        }


        private void btnDeletar_Click_1(object sender, EventArgs e)
        {
            {
                try
                {
                    if (!txtNome.Text.Equals("") && !txtEmail.Text.Equals("") && !txtCPF.Text.Equals("") && !txtEndereco.Text.Equals(""))
                    {
                        CadastroFuncionarios cadFuncionarios = new CadastroFuncionarios();
                        cadFuncionarios.Id = int.Parse(lblId.Text);
                        if (cadFuncionarios.deletarFuncionario())
                        {
                            MessageBox.Show("O funcionario foi deletado com sucesso!");
                            txtCPF.Clear();
                            txtEmail.Clear();
                            txtEndereco.Clear();
                            txtNome.Clear();
                            txtCPF.Focus();
                            lblId.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Não foi possivel excluir funcionario");
                            txtCPF.Clear();
                            txtEmail.Clear();
                            txtEndereco.Clear();
                            txtNome.Clear();
                            txtCPF.Focus();
                            lblId.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Favor pesquisar qual funcionario deseja excluir");
                        txtCPF.Clear();
                        txtEmail.Clear();
                        txtEndereco.Clear();
                        txtNome.Clear();
                        txtCPF.Focus();
                        lblId.Text = "";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir funcionario: " + ex.Message);

                }
            }
        }
    }
}
