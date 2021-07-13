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
                        ModuloUsuario moduloUsuario = new ModuloUsuario();
                        moduloUsuario.Create();                        
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
