using System;
class Media {
  static void Main() {
      double ava1, ava2, media;
      Console.WriteLine("Programa de Nédia de Notas");
      Console.WriteLine("Insira a 1º Nota: ");
      ava1 = double.Parse(Console.ReadLine ());
      Console.WriteLine("Insira a 2º Nota: ");
      ava2 = double.Parse(Console.ReadLine ());
      media = (ava1 + ava2) /2;
      
      if(media>6){
            Console.WriteLine($"O aluno está aprovado! a média é: {media}"); 
      }
        else{  
            Console.WriteLine($"O aluno está reprovado! a média é: {media}");
      }
  }
}