 public new class QueueTraining {
     //criar empty constructor
     public QueueTraining () { }

     public void QueueExample () {
         Queue<int> queue = new Queue<int> ();
         queue.Enqueue (1);
         queue.Enqueue (2);
         queue.Enqueue (3);
         queue.Enqueue (4);
         queue.Enqueue (5);

         Console.WriteLine ("Queue elements:");
         foreach (var item in queue) {
             Console.WriteLine (item);
         }

         Console.WriteLine ("Dequeue elements:");
         while (queue.Count > 0) {
             Console.WriteLine (queue.Dequeue ());
         }
     }
 }