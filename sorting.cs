using System;
using System.Collections.Generic;



class Progam
{
  static void sort(string n){
    string[] s = n.Split(',');
    Console.WriteLine(s.Length);
    List<int> numbers = new List<int>();
    foreach (var number in s)
    {
      int thisNumber  = int.Parse(number);
      numbers.Add(thisNumber);
    }
    int counter = numbers.Count;
    Console.WriteLine(counter);
    while(counter > 0){

      List<int> copy = new List<int>(numbers);
      int i = 0;
      for (i=i; i < (numbers.Count - 1); i++){
        if ( numbers[i] < numbers[i+1]){

          numbers[i] = copy[i+1];
          numbers[i+1]=copy[i];
          i = i+1;
        }
      }
      counter = counter - 1;
    }
    foreach (var l in numbers)
    Console.WriteLine(l);
  }




  public static void Main()
  {
    string n = "300,200,100,1000";
    sort(n);



  }
}
