using System;

class Program {
  static string alfabeto = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]";
  public static void Main(){
      Console.WriteLine("Ingrese la frase a cifrar");

      string msj = Console.ReadLine();
      while (string.IsNullOrEmpty(msj))
      {
          Console.WriteLine("Ingrese un mensaje no vacio");
          msj = Console.ReadLine();
      }
      Program program = new Program(); 
      program.cifrar(msj);
      Console.WriteLine("Ingrese la frase a descifrar");
      string msj2 = Console.ReadLine();
      while (string.IsNullOrEmpty(msj2)){
          Console.WriteLine("Ingrese un mensaje no vacio");
          msj2 = Console.ReadLine();
      }
      program.descifrar(msj2);
  }
  public string cifrar(string msj){
      string msjCifrado = ""; 
     foreach(char c in msj){
         int pos = alfabeto.IndexOf(c);
         if(pos == -1){
             msjCifrado += c;
         } else {
           int newPos = (pos + 7 + alfabeto.Length) % alfabeto.Length;
           msjCifrado += alfabeto[newPos];
       }
     } 
     Console.WriteLine("Mensaje cifrado: "+msjCifrado);
     return msjCifrado;
  }

  
  public string descifrar(string msjCifrado) {
          string msjDescifrado = "";
          foreach (char c in msjCifrado) {
              int pos = alfabeto.IndexOf(c);
              if (pos == -1) {
                  msjDescifrado += c;
              } else {
                  int newPos = (pos - 7 + alfabeto.Length) % alfabeto.Length;
                  msjDescifrado += alfabeto[newPos];
              }
          }   
          Console.WriteLine("Mensaje descifrado: " + msjDescifrado);
          return msjDescifrado;
      }
}
