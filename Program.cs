using System;

namespace CalculadoraIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-- Calculadora de IMC --");

            Console.Write("Digite seu peso em kg...: ");
            double _peso = float.Parse(Console.ReadLine());
            Console.Write("Digite sua altura em m..: ");
            double _altura = float.Parse(Console.ReadLine());

            double _imc = _peso/(Math.Pow(_altura,2));
            Console.WriteLine($"\nSeu IMC é de {Math.Round(_imc,2)}.");
            
            string _diagnostico = _imc < 17 ? "Muito Abaixo do Peso" : 
            _imc > 17 && _imc < 18.49 ? "Abaixo do peso" :
            _imc > 18.5 && _imc < 24.99 ? "Peso normal" :
            _imc > 25 && _imc < 29.99  ? "Acima do peso" :
            _imc > 30 && _imc < 34.99  ? "Obesidade I" :
            _imc > 35 && _imc < 39.99  ? "Obesidade II" :
            "Obesidade III";
            
            Console.WriteLine($"Diagnóstico: {_diagnostico}");
        }
    }
}
