using System;

class Program {
  static string alfabeto = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ1234567890_-+,#$%&/()=¿?¡!|,.;:{}[]";
  public static void Main(){
      Console.WriteLine("Ingrese la frase a cifrar");
      string msj = Console.ReadLine();
    Console.WriteLine("Ingrese la distancia para cifrar");
    string dist = Console.ReadLine();
     int distance = Convert.ToInt32(dist);
      while (string.IsNullOrEmpty(msj))
      {
          Console.WriteLine("Ingrese un mensaje no vacio");
          msj = Console.ReadLine();
      }
      Program program = new Program(); 
      program.cifrar(msj, distance);
      Console.WriteLine("Ingrese la frase a descifrar");
      string msj2 = Console.ReadLine();
    Console.WriteLine("Ingrese la distancia para descifrar");
    string dist2 = Console.ReadLine();
   int distance2 = Convert.ToInt32(dist2);
      while (string.IsNullOrEmpty(msj2)){
          Console.WriteLine("Ingrese un mensaje no vacio");
          msj2 = Console.ReadLine();
      }
      program.descifrar(msj2,distance2);
  }
  public string cifrar(string msj,int dist){
      string msjCifrado = ""; 
     foreach(char c in msj){
         int pos = alfabeto.IndexOf(c);
         if(pos == -1){
             msjCifrado += c;
         } else {
           int newPos = (pos + dist + alfabeto.Length) % alfabeto.Length;
           msjCifrado += alfabeto[newPos];
       }
     } 
     Console.WriteLine("Mensaje cifrado: "+msjCifrado);
     return msjCifrado;
  }


  public string descifrar(string msjCifrado, int dist) {
          string msjDescifrado = "";
          foreach (char c in msjCifrado) {
              int pos = alfabeto.IndexOf(c);
              if (pos == -1) {
                  msjDescifrado += c;
              } else {
                  int newPos = (pos - dist + alfabeto.Length) % alfabeto.Length;
                  msjDescifrado += alfabeto[newPos];
              }
          }   
          Console.WriteLine("Mensaje descifrado: " + msjDescifrado);
          return msjDescifrado;
      }
}
