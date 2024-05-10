using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Calculo_Salario_POO
{
 internal class Program
 {
  static void Main(string[] args)
  {
Funcionario func = new Funcionario();

   Console.WriteLine("Entre com as Informações do funcionario");
   Console.Write("Nome: ");
   func.Nome = Console.ReadLine();
   Console.Write("Salario bruto: ");
   func.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
   Console.Write("Imposto: ");
   func.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
   Console.WriteLine("-----------------------------------------");

   Console.WriteLine($"Funcionario:  {func}");
   Console.WriteLine("-----------------------------------------");

   Console.Write("Deseka aumentar o salario em qual porcentagem: ");
   double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
   func.AumentoSalario(porcent);
   Console.WriteLine("-----------------------------------------");

   Console.WriteLine($"Dados Atualizados:  {func} ");




  }
 }
}
