using System;
using System.Collections.Generic;

class ideias {

  private List<string> descricao = new List<string>();
  private List<string> areaAtuacao = new List<string>();
  private List<string> autor = new List<string>();
  private List<double> valorMinNecessario = new List<double>();
  private List<int> votos = new List<int>();

  public void setIdeia(string a,string b,string c,double d){
    this.descricao.Add(a);
    this.areaAtuacao.Add(b);
    this.autor.Add(c);
    this.valorMinNecessario.Add(d);
  }

  public void getIdeia(){
    for(int i = 0;i < this.valorMinNecessario.Count;i++){
      Console.WriteLine("Ideia | Descrição | Área | Autor");
      Console.WriteLine("{0} | {1} | {2} | {3}",i,this.descricao[i],this.areaAtuacao[i],this.autor[i]);
    }
  }

  public bool cadIdeia(){
    string desc = "";
    string area = "";
    string autor = "";
    string valorMin = "";
    string confirm;

    while (desc == "" || area == "" || autor == "" || valorMin == ""){
      try {
        if (desc == ""){
          Console.WriteLine("Digite a descrição de sua ideia!");
          desc = Console.ReadLine();
        }

        if (area == ""){
          Console.WriteLine("Digite a área de atuação de sua ideia!");
          area = Console.ReadLine();
        }

        if (autor == ""){
          Console.WriteLine("Digite seu nome:");
          autor = Console.ReadLine();
        }

        if (valorMin == ""){
          Console.WriteLine("Digite o valor mínimo para que sua ideia seja executada!");
          valorMin = Console.ReadLine();
        }

        Console.WriteLine("Digite 's' para cadastrar outra ideia ou qualquer outra tecla para sair!");
        confirm = Console.ReadLine();

        double valorConvert = double.Parse(valorMin);
        
        setIdeia(desc,area,autor,valorConvert);

        if (confirm != "s"){
          return false;
        }

      } catch (FormatException)
      {
        Console.WriteLine("Valor digitado inválido!");
      }
    }
    return true;
  }

  public void curtir(int index){
    int indexVotado;

    try{
      Console.WriteLine("Digite o número da ideia que deseja votar!");
      indexVotado = int.Parse(Console.ReadLine());
      this.votos.Add(indexVotado);
    } catch(FormatException){
      Console.WriteLine("Valor inválido!");
    }
  }


}