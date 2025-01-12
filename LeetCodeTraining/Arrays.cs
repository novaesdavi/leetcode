using System.Globalization;
using System.Runtime.Versioning;

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

        public void isAnagram () {
            // Base method implementation
            string s = "anagram";
            string t = "nagaram";
            Dictionary<int, char> dict = new Dictionary<int, char> ();

            if (s.Length != t.Length) {
                Console.WriteLine ("It is not an anagram");
                return;
            }

            for (int i = 0; i < t.Length; i++) {
                for (int j = 0; j < s.Length; j++) {
                    if (t[i] == s[j]) {
                        dict.Add (i, s[j]);
                        s.Remove (j);
                        break;
                    }
                }
            }

            if (dict.Count == s.Length) {
                Console.WriteLine ("Is anagram");
            } else {
                Console.WriteLine ("It is not an anagram");
            }
        }

        public void isAnagramWithSortSolution () {
            // Base method implementation
            string s = "anagram";
            string t = "nagaram";

            if (s.Length != t.Length) {
                Console.WriteLine ("It is not an anagram");
                return;
            }

            var s_sorted = s.ToCharArray ().OrderBy (x => x).ToArray ();
            var t_sorted = t.ToCharArray ().OrderBy (x => x).ToArray ();

            for (int i = 0; i < s_sorted.Length; i++) {
                if (s_sorted[i] != t_sorted[i]) {
                    Console.WriteLine ("It is not an anagram");
                    return;
                }
            }

            Console.WriteLine ("Is anagram");

        }

        public void isAnagramWithFrequencyCount () {
            // Base method implementation
            string s = "anagram";
            string t = "nagaram";

            if (s.Length != t.Length) {
                Console.WriteLine ("It is not an anagram");
                return;
            }

            Dictionary<char, int> s_freq = new Dictionary<char, int> ();

            for (int i = 0; i < s.Length; i++) {
                if (s_freq.ContainsKey (s[i])) {
                    s_freq[s[i]]++;
                } else {
                    s_freq.Add (s[i], 1);
                }
            }

            for (int j = 0; j < t.Length; j++) {
                if (s_freq.ContainsKey (t[j])) {
                    s_freq[t[j]]--;
                } else {
                    Console.WriteLine ("It is not an anagram");
                    return;
                }
            }

            foreach (var item in s_freq) {
                if (item.Value != 0) {
                    Console.WriteLine ("It is not an anagram");
                    return;
                }
            }

            Console.WriteLine ("Is anagram");
        }

        public void isAnagramSortEnhanced () {
            // Base method implementation
            string s = "anagram";
            string t = "nagaram";

            if (s.Length != t.Length) {
                Console.WriteLine ("It is not an anagram");
                return;
            }

            Dictionary<char, int> s_freq = new Dictionary<char, int> ();

            string s_sorted = new string (s.OrderBy (x => x).ToArray ());
            string t_sorted = new string (t.OrderBy (x => x).ToArray ());

            if (s_sorted != t_sorted) {
                Console.WriteLine ("It is not an anagram");
                return;
            }
            Console.WriteLine ("Is anagram");
        }
        public void CelebrityProblem () {

            int[][] InPut = new int[][] {
                new int[] { 0, 0, 1, 0 },
                new int[] { 0, 0, 1, 0 },
                new int[] { 0, 0, 1, 0 },
                new int[] { 0, 0, 1, 0 },

            };
            int[] Knowledge = new int[] { 0, 0, 0, 0 };
            for (int i = 0; i < InPut.Length; i++) {

                for (int j = 0; j < InPut[i].Length; j++) {
                    Console.WriteLine ($"InPut[{i}][{j}] = {InPut[i][j]}");
                    if (InPut[i][j] == 1) {
                        Knowledge[i] = j;
                        break;
                    }
                }
            }

            for (int i = 0; i < Knowledge.Length; i++) {
                if (Knowledge[i] == 0) {
                    Console.WriteLine ($"Celebrity: {i}");
                    return;
                }

            }

            Console.WriteLine ("No celebrity found");

        }

    }
}