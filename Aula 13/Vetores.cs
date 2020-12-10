using System;

class MainClass {
  public static void Main (string[] args) {
    //int[] v = new int[10];
    //Console.WriteLine(v[0]);
    //Console.WriteLine(v.Length);

    int[] w = { 1, 3, 5, 7, 9, 2, 4, 6, 8, 0 };
    //Console.WriteLine(w[0]);

    //for(int i = 0; i < w.Length; i++)
    //  Console.WriteLine(w[i]);
    
    Array.Sort(w);
    Array.Reverse(w);

    //foreach(int x in w)  
    //  Console.WriteLine(x);

    int[] z = (int[]) w.Clone(); 
    z[0] = 20;
    z[9] = 40;

    foreach(int x in w)  
      Console.WriteLine(x);
    foreach(int x in z)  
      Console.WriteLine(x);

  }
}