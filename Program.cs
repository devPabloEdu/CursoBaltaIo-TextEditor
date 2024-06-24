using System;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
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
                default : Menu();
                break;
            }
        }

        static void Abrir(){
            Console.Clear();
            Console.WriteLine("Qual o caminho do arquivo ? ");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path))
            {
              string text = file.ReadToEnd();  
              Console.WriteLine(text);
            }
            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }
        static void Editar(){
            Console.Clear();
            Console.WriteLine("DIGITE SEU TEXTO ABAIXO: (ESC para sair)");
            Console.WriteLine("------------------------");
            string text = "";

            do {
                text += Console.ReadLine();
                text += Environment.NewLine;
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape);

            Salvar(text);

            }
        static void Salvar(string text){
            Console.Clear();
            Console.WriteLine("Qual o caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using (var file = new StreamWriter(path))
            {
                file.Write(text);
            }
            Console.WriteLine($"ARQUIVO SALVO COM SUCESSO NO CAMINHO : {path}");
            Console.ReadLine();
            Menu();
        }
        }
}

