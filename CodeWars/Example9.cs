using System;


class Example9
{
  public static bool lovefun(int flower1, int flower2)
  {
    return (flower1 % 2 == 1 && flower2 % 2 == 0) // Περιττός και άρτιος (true)
        || (flower1 % 2 == 0 && flower2 % 2 == 1); // Άρτιος και περιττός (true)
  }
}

/*
ι κάνει το modulo:
αριθμός % 2 → επιστρέφει το υπόλοιπο της διαίρεσης με το 2
Αν το υπόλοιπο είναι 0 → άρτιος αριθμός
Αν το υπόλοιπο είναι 1 → περιττός αριθμός
*/


