namespace LeetCode.Arrays {
    public class ArraysTraining {
        public void TwoPointer () {
            // Base method implementation
            string[] InputX = new string[] { "racecar", "a", "b", "abcdcba", "e" };

            for (int i = 0; i < InputX.Length; i++) {

                int tamanhoString = InputX[i].Length;
                int meioString = tamanhoString / 2;
                int cursorContrario = tamanhoString - 1;
                for (int j = 0; j <= meioString; j++) {

                    if (InputX[i][j].ToString () == InputX[i][cursorContrario].ToString () && j <= meioString) {
                        Console.WriteLine ($"InputX[{i}][{cursorContrario}] = {InputX[i][cursorContrario]}");
                        if (j >= meioString) {
                            Console.WriteLine ($"Palimdromo: {InputX[i]}");
                            break;
                        }
                        cursorContrario--;
                    }

                }
            }
        }
    }
}