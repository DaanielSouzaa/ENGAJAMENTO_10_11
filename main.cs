using System;

class MainClass {
  public static void Main (string[] args) {
    ideias ideia = new ideias();
    votacao voto = new votacao();

    bool validaCad = true;
    while(validaCad == true){
      validaCad = ideia.cadIdeia();
    }

    ideia.getIdeia();

  //INICIA PROCESSO DE VOTAÇÃO

    bool validaJuri = false;
    while (validaJuri == false){
      validaJuri = voto.setJurados();
    }
  }
}