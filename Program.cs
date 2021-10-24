using System;

namespace ExercicioIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            float imc, peso, altura;

            Console.Write ("-- Calculadora de IMC --");
            Console.WriteLine();

            Console.Write ("Digite seu peso (em kg):");
            peso = float.Parse(Console.ReadLine());

            Console.Write ("Digite a sua altura (em metros):");
            altura = float.Parse(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 17)
            {
                Console.WriteLine ("Muito abaixo do peso");               
            }
            else if ((imc > 17) && (imc < 18.49))
            {
                Console.WriteLine("Abaixo do peso");
            }
            else  if ((imc > 18.5) && (imc < 24.99))
            {
                Console.WriteLine("Peso normal");
            }
            else if ((imc > 25) && (imc < 29.99))
            {
                Console.WriteLine("Acima do peso");
            }
            else if ((imc > 30) && (imc < 34.99))
            {
                Console.WriteLine("Obesidade I");
            }
            else if ((imc > 35) && (imc < 39.99))
            {
                Console.WriteLine("Obesidade II (severa)");
            }
             else  if (imc > 40)
            {
                Console.WriteLine("Obesidade III (Mórbida)");
            }
            Console.ReadKey();
        }
    }
}
