 public class QueueTraining {
     //criar empty constructor
     public QueueTraining () { }
     int[] queue = new int[5];
     int head = 0;
     int tail = 0;
     public void QueueBuiltWrongly () {

         for (int i = 0; i < 4; i++) {
             Enqueue (i); //First value in
         }

         for (int i = 0; i < 2; i++) {
             Dequeue (); //First out
         }

         for (int i = 0; i < 4; i++) {
             Enqueue (i); //First value in
         }

     }

     public void Enqueue (int value) {
         if (IsQueueFull ()) {
             Console.WriteLine ("Queue is full");
         } else {
             queue[tail] = value;
             tail++;
         }
     }

     private bool IsQueueFull () {
         //  return tail == queue.Length - 1;
         return tail == queue.Length;
     }

     public void Dequeue () {
         if (IsQueueEmpty ()) {
             Console.WriteLine ("Queue is empty");
         } else {
             queue[head] = 0;
             head++;
         }
     }

     private bool IsQueueEmpty () {
         return head == tail;
     }

     public void QueueExampleByQueueInDotNet () {
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