using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;

namespace ConsoleApp1
{
    class Menu
    {
        public static void MontaMenu()
        {
            //cabecalho
            Cabecalho();
            //opcoes
            Opcoes();
            //rodape
            Rodape();
            //escolha
            Escolha();
        }

        private static void Rodape()
        {
            Console.WriteLine("*********************************************************");
            Console.Write("Escolha um opção do menu:");
        }

        private static void Opcoes()
        {
            Console.WriteLine("\t1-Cadastrar Usuário");
            Console.WriteLine("\t2-Cadastrar Produto");
            Console.WriteLine("\t0-Sair");
        }

        private static void Cabecalho()
        {
            Console.WriteLine("*********************  Havan Labs ***********************");
            Console.WriteLine("*********************  Bem-vindo ************************");
        }
        private static void Escolha()
        {
            int opcao = 0;
            do
            {
                opcao =  Validacao.ValidaInteiros();  
                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("Tchau");
                        break;
                    case 1:
                        string resposta = "";
                        List<Usuario> usuarios = new List<Usuario>();
                        do
                        {
                            Usuario user = new Usuario();
                            user.Cadastro();                            
                            Console.WriteLine("Deseja cadastrar mais 1?(y/n)");
                            resposta = Console.ReadLine();
                            
                            usuarios.Add(user);
                        } while (resposta == "y");
                        
                        Usuario userSelect1 = usuarios.First(u=>u.nome.Equals("chimbinha")); // C# linq - lambda
                        Usuario userSelect2 = (from u in usuarios where u.nome == "chimbinha" select u).First();

                        foreach (var item in usuarios)
                        {
                            Console.WriteLine($"Usuario -\n nome:{item.nome.ToLower()}\n sobrenome:{item.sobrenome.ToLower()}\n idade:{item.idade}\n email:{item.email.ToLower()}\n end:{item.endereco}\n");
                        }
                        
                        break;
                    case 2:
                        Console.WriteLine("Em implementacao (falta dev)");
                        break;
                    default:
                        Console.WriteLine("Opcao invalida! Digite 0,1,2");
                        break;
                }
                
            } while (opcao < 0 || opcao > 2) ;
        }
    }
}
