using System.Collections.Generic;
using System;
namespace ScrabbleApp.Models
{
  public class Scrabble1
  {
    private string _word;
    private int _score;

    public Scrabble1 (string word, int score = 0)
    {
      _word = word;
      _score = score;
    }
    public int GetScore()
    {

      return _score;
    }
    public int scrabble(){
      char[] firstarray= {'a','e','c'};
      char[] secondarray= {'h','l','o'};
      char[] s = _word.ToCharArray();
      int score = 0 ;

      foreach(var l in s){
        for(var i = 0; i < firstarray.Length; i++){

          if( l == firstarray[i])
          score = score + 1;

          if(l == secondarray[i])
          score = score +2;

        }
      }
      return score;
    }

  }
}
