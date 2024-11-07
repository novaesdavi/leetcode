namespace LeetCode.Arrays {
    public class ArraysTraining {
        public void TwoPointerPalindrome () {
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

        public void TwoPointerTarget () {
            // Base method implementation
            int[] InputX = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int target = 15;
            int CurrentRightPosition = InputX.Length - 1;
            for (int i = 0; i < InputX.Length; i++) {

                if (InputX[i] + InputX[CurrentRightPosition] == target) {
                    Console.WriteLine ($"{InputX[i]} + {InputX[CurrentRightPosition]} = {target}");
                    break;
                }

                for (; CurrentRightPosition > 0; CurrentRightPosition--) {

                    if (InputX[CurrentRightPosition] < target) {
                        break;
                    }

                }

            }
        }

        public void TwoPointerTargetWhile () {
            // Base method implementation
            int[] InputX = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13];
            int target = 9;
            int CurrentRightPosition = InputX.Length - 1;
            int CurrentLeftPosition = 0;

            while (CurrentLeftPosition < CurrentRightPosition) {
                if (InputX[CurrentLeftPosition] + InputX[CurrentRightPosition] == target) {
                    Console.WriteLine ($"{InputX[CurrentLeftPosition]} + {InputX[CurrentRightPosition]} = {target}");
                    break;
                } else if (InputX[CurrentRightPosition] < target) {
                    CurrentLeftPosition++;
                } else {
                    CurrentRightPosition--;
                }
            }

        }
    }
}