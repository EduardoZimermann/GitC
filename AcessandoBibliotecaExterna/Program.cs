
using BibliotecaDeArquivosDoWindows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessandoBibliotecaExterna
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new GetFiles();

            Console.WriteLine("Arquivos de meus documentos:");

            for (int i = 0; i < lista.RetornaArquivosDoMeuDocumentos().Length; i++)
                Console.WriteLine(lista.RetornaArquivosDoMeuDocumentos()[i]);

            Console.WriteLine("\r\nArquivos de minhas imagens:");

            for (int i = 0; i < lista.RetornaArquivosImagesFiles().Length; i++)
                Console.WriteLine(lista.RetornaArquivosImagesFiles()[i]);

            Console.WriteLine("\r\nArquivos do meu GitC:");

            if (lista.RetornaArquivosGit() != null)
            {
                for (int i = 0; i < lista.RetornaArquivosGit().Length; i++)
                    Console.WriteLine(lista.RetornaArquivosGit()[i]);
            }
            else
                Console.WriteLine("Não deu certo meu cabron");

            Console.ReadKey();
        }
    }
}
