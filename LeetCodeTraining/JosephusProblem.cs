using System;

public class JosephusProblem {
    // Definição do nó
    public class Node {
        public int Data;
        public Node Next;

        public Node (int data) {
            Data = data;
            Next = null;
        }
    }

    private Node head = null;

    // Método para adicionar um nó ao final da lista circular
    public void Add (int data) {
        Node newNode = new Node (data);
        if (head == null) {
            head = newNode;
            head.Next = head;
            Console.WriteLine ($"Adicionando DATA: {head.Data} NEXT: {head.Next.Data}");
        } else {
            Node current = head;
            while (current.Next != head) {
                current = current.Next;
            }

            current.Next = newNode;
            newNode.Next = head;

            Console.WriteLine ($"Adicionando DATA: {current.Data} NEXT: {current.Next.Data}");
        }
    }

    // Método para resolver o problema de Josephus
    public int SolveJosephus (int step) {
        if (head == null || step < 1)
            throw new ArgumentException ("Lista está vazia ou passo inválido.");

        Node current = head;
        Node previous = null;

        // Enquanto mais de um nó existir na lista
        while (current.Next != current) {
            // Pular (step - 1) nós
            for (int i = 1; i < step; i++) {
                previous = current;
                current = current.Next;
            }

            // Remover o nó atual
            Console.WriteLine ($"Eliminando: {current.Data}");
            previous.Next = current.Next;
            current = current.Next;
        }

        // O último nó restante é o sobrevivente
        return current.Data;
    }
}