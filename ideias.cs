using System;
using System.Collections.Generic;

class ideias {

  private List<string> descricao = new List<string>();
  private List<string> areaAtuacao = new List<string>();
  private List<string> autor = new List<string>();
  private List<double> valorMinNecessario = new List<double>();

  public void setIdeia(string a,string b,string c,double d){
    this.descricao.Add(a);
    this.areaAtuacao.Add(b);
    this.autor.Add(c);
    this.valorMinNecessario.Add(d);
  }

  public void getIdeia(){
    Console.WriteLine(descricao[0]);
  }

  public bool cadIdeia(){
    string desc;
    string area;
    string autor;
    double valorMin;
    string confirm;

    while (desc == "" || area == "" || autor == "" || valorMin == ""){
      try {
        if (desc == ""){
          Console.WriteLine("Digite a descrição de sua ideia!");
          desc = Console.ReadLine();
        };

        if (area == ""){
          Console.WriteLine("Digite a área de atuação de sua ideia!");
          area = Console.ReadLine();
        };

        if (autor == ""){
          Console.WriteLine("Digite seu nome:");
          autor = Console.ReadLine();
        };

        if (valorMin == ""){
          Console.WriteLine("Digite o valor mínimo para que sua ideia seja executada!");
          valorMin = double.Parse(Console.ReadLine());
        };

        Console.WriteLine("Digite 's' para cadastrar outra ideia ou qualquer outra tecla para sair!");
        confirm = Console.ReadLine();
        
        setIdeia(desc,area,autor,valorMin);

        if (confirm != "s"){
          return false;
        }

      } catch (FormatException)
      {
        Console.WriteLine("Valor digitado inválido!");
      }
      return true;
    }
  }
}