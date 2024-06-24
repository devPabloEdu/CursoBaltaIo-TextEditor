using System;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static void Menu(){
            Console.Clear();
            Console.WriteLine("O que você deseja fazer?");
            Console.WriteLine("1 - ABRIR ARQUIVO");
            Console.WriteLine("2 - CRIAR NOVO ARQUIVO");
            Console.WriteLine("0 - SAIR");
            short option = short.Parse(Console.ReadLine());

            switch(option){
                case 0 : System.Environment.Exit(0);
                break;
                case 1 : Abrir();
                break;
                case 2 : Editar();
                break;
            }
        }

        static void Abrir(){

        }
        static void Editar(){

        }
    }
}
