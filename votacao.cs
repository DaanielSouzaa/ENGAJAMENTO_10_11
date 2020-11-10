using System;
using System.Collections.Generic;

class votacao {
private quantidadeJurados;
private List<double> notas = new List<double>();

public bool setJurados(){
  int jurados;

  try {
    Console.WriteLine("Quando a quantidade de jurados?");
    jurados = int.Parse(Console.ReadLine());
    this.quantidadeJurados=jurados;
  } catch(FormatException) {
    Console.WriteLine("Valor inválido!");
    return false;
  }

  return true;
};

};
