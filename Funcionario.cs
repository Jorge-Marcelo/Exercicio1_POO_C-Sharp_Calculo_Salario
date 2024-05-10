using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Calculo_Salario_POO
{
 internal class Funcionario
 {
public string Nome{ get; set; }
public double SalarioBruto { get; set; }
public double Imposto { get; set; }


  public double SalarioLiquido() { return SalarioBruto - Imposto; }

public void AumentoSalario(double porcentagem){
   SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
  }

  public override string ToString()
  {
   return $"{Nome} R$ {SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}";
  }

 }
}
