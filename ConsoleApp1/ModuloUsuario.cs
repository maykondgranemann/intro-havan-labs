using Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ModuloUsuario
    {
        UsuarioRepository repository = new UsuarioRepository();

        public void Create()
        {
            string resposta = "";            
            do
            {
                Console.Write("Digite o nome:");
                string nome = Validacao.ValidaStringEmBranco();
                Console.Write("Digite o sobrenome:");
                string sobrenome = Validacao.ValidaStringEmBranco();
                Console.Write("Digite o idade:");
                int idade = Validacao.ValidaInteiros();
                Console.Write("Digite o email:");
                string email = Validacao.ValidaStringEmBranco();
                Console.Write("Digite o endereco:");
                string endereco = Validacao.ValidaStringEmBranco();
                Usuario model = new Usuario(nome, sobrenome, idade, email, endereco);
                repository.Create(model);
                Console.WriteLine("Deseja cadastrar mais 1?(y/n)");
                resposta = Console.ReadLine();

            } while (resposta == "y");
        }
    }
}
