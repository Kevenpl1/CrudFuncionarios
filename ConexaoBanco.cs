using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    static class ConexaoBanco
    {           
        
        // 4 variaveis declaradas passando as informaçoes do banco
        private const string servidor = "localhost";
        private const string bancoDados = "dbFuncionarios";
        private const string user = "root";
        private const string password = "Comida5383";

        //declarando variavel conexaoBnaco para fazer conexao com o banco de dados.
        static public string bancoServidor = $"server={servidor};user id = {user}; database = {bancoDados}; password = {password}";


            
    }
}
