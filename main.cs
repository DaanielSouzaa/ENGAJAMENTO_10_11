using System;

class MainClass {
  public static void Main (string[] args) {
    ideias ideia = new ideias();

    bool validaCad = true;
    while(validaCad == true){
      validaCad = ideia.cadIdeia();
    }

    bool visualizaIdeias = true;
    while(visualizaIdeias == true){
      ideia.getIdeia();
      ideia.curtir();
    }
  }
}