using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValorDoJuros
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string valor;
            int valorRecebido = 0;
            double _valorJuros = 0.0;
            CalcValorJuros _calcValorJuros = new CalcValorJuros();
            do
            {                           
                Console.Write(@"Bem Vindo, informa o valor do título para informarmos o valor do juros diário.
                \n Digite o Valor : R$ ");
                VerificaValor<Double>.verificarValor(Console.ReadLine(), TypeDados._double);
                

                Console.WriteLine(String.Format(" \n Valor do Juros R$ {0}", _valorJuros));
                
                Console.WriteLine("Se Desejar Sair do programa \n \t DIGITE 0");
                valorRecebido = int.Parse(Console.ReadLine());
                 
            } while (valorRecebido != 0);            
            

        }
    }
    public class VerificaValor<T>
    {
        
       public static  bool verificarValor(string dados, TypeDados typoDados)
        {
            if(typoDados.Equals(TypeDados._double)
            {
                return false;
            }
            return false;
        }
    }

    public enum TypeDados
    {
        _inteiro,_double
    }
   public class CalcValorJuros
   {
        public Double _valorDoJuros{ get; set; }


        public Double CalcularJuros(double valor)
        {            
            return _valorDoJuros = ((valor * 0.01) /30);            
        }
   }
}

