using System;

namespace DesafioAula3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float largura, altura, porta, janela, desconto, litrosTinta, areaParede, areaTeto, areaTotal;

            Console.WriteLine("Informe as mediadas do local: ");

            Console.WriteLine("Largura de todas as paredes: ");
            largura = float.Parse(Console.ReadLine());

            Console.WriteLine("Altura de todas as paredes: ");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o tamanho da porta: ");
            porta = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o tamanho da janela: ");
            janela = float.Parse(Console.ReadLine());

            desconto = janela + porta;

            areaParede = (largura * altura) - desconto;

            areaTeto = (largura * altura) - desconto;

            areaTotal = areaParede + areaTeto;


            litrosTinta = areaTotal/100;

            Console.WriteLine($"A area das paredes é : {areaParede} metros ");

            Console.WriteLine($"A area do teto é : {areaTeto} metros ");

            Console.WriteLine($"Serão necessários {litrosTinta} litros de tinta.");

        }
    }
}
