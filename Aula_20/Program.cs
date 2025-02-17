namespace Aula_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Carro carro = new Carro();
            carro.DigaSeuNome();

            Aviao aviao = new Aviao();
            aviao.DigaSeuNome();

            MeusTestes.Carro carro1 = new MeusTestes.Carro();
            carro1.DigaSeuNome();

            Console.Read();

        }
    }


    class Carro
    {
        public void DigaSeuNome()
        {
            Console.WriteLine("Eu sou um carro");
        }
    }
}



namespace MeusTestes
{
    class Carro
    {
        public void DigaSeuNome()
        {
            Console.WriteLine("Eu sou um carro dentro do namespace MeusTestes");
        }
    }
}

class Aviao
{
    public void DigaSeuNome()
    { 
        Console.WriteLine("Eu sou um aviao");
    }
       
}