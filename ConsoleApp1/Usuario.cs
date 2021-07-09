using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace ConsoleApp1
{
    class Usuario
    {
        public string nome = String.Empty;
        public string sobrenome = String.Empty;
        public int idade = 0;
        public string email = String.Empty;
        public string endereco = String.Empty;

        public void Cadastro()
        {
            Console.Write("Digite o nome:");         
            this.nome = Validacao.ValidaStringEmBranco();
            Console.Write("Digite o sobrenome:");
            this.sobrenome = Validacao.ValidaStringEmBranco();
            Console.Write("Digite o idade:");
            this.idade = Validacao.ValidaInteiros(); 
            Console.Write("Digite o email:");
            this.email = Validacao.ValidaStringEmBranco();
            Console.Write("Digite o endereco:");
            this.endereco = Validacao.ValidaStringEmBranco();
            
        }

        
    }
}
