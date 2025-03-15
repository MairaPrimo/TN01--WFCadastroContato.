using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAcesso
{
    public class Usuario
    {
        public int Codigo { get; set; }
        public string? Login { get; set; }
        public string? Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        public static List<Usuario>
            ListaUsuarios = new List
            <Usuario>();

        public Usuario(int codigo, string logar, string senha, DateTime dataCadastro)
        {
            Codigo = codigo;
            Login = logar;
            Senha = senha;
            DataCadastro = dataCadastro;
        }
        public Usuario() { }
        
     
    }
}
