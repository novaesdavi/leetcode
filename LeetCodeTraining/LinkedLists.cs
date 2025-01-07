using System;

public class LinkedLists {

    public void ExecuteJosephusProblem () {
        JosephusProblem list = new JosephusProblem ();

        // Número de pessoas no círculo
        int n = 30; // Exemplo com 7 pessoas
        int step = 9; // Exclui a cada 9ª pessoa

        // Criar o círculo
        for (int i = 1; i <= n; i++) {
            list.Add (i);
        }

        // Resolver o problema de Josephus
        Console.WriteLine ("Resolvendo o problema de Josephus...");
        int survivor = list.SolveJosephus (step);

        Console.WriteLine ($"\nA pessoa que sobreviveu está na posição: {survivor}");

    }

    public void ExecuteJosephusProblemGroup () {
        JosephusProblemGroup list = new JosephusProblemGroup ();

        // Número de pessoas no círculo
        int n = 7; // Exemplo com 7 pessoas
        int step = 3; // Exclui a cada 3ª pessoa

        // Criar o círculo
        for (int i = 1; i <= n; i++) {
            list.Add (i);
        }

        // Resolver o problema de Josephus
        Console.WriteLine ("Resolvendo o problema de Josephus...");
        int survivor = list.SolveJosephus (step);

        Console.WriteLine ($"\nA pessoa que sobreviveu está na posição: {survivor}");

    }

}