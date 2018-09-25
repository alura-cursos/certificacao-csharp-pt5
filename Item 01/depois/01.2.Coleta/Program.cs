using System;
using System.Threading.Tasks;

namespace _01._02.TiposDeReferencia
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Task.Delay(3000); //aguarda 3 segundos

            //GerarTiposValor();
            GerarTiposReferencia();

            Console.ReadKey();
        }

        private static void GerarTiposValor()
        {
            for (long i = 0; i < 100000; i++)
            {
                EstruturaLivro livro = new EstruturaLivro
                {
                    NumeroPaginas = 1200
                };
            }
        }
        ///<image url="$(ProjectDir)\img1.png"/>




        private static void GerarTiposReferencia()
        {
            for (long i = 0; i < 100000; i++)
            {
                ClasseLivro livro = new ClasseLivro
                {
                    Introducao = new string(' ', 100000),
                    Texto = new string(' ', 100000),
                    Conclusao = new string(' ', 100000)
                };
            }
        }
        ///<image url="$(ProjectDir)\img2.png"/>
        ///<image url="$(ProjectDir)\img4.png"/>
        ///<image url="$(ProjectDir)\img5.png"/>
        ///<image url="$(ProjectDir)\img6.png"/>
    }

    struct EstruturaLivro
    {
        public double NumeroPaginas { get; set; }
    }

    class ClasseLivro
    {
        public string Introducao { get; set; }
        public string Texto { get; set; }
        public string Conclusao { get; set; }
    }
}

