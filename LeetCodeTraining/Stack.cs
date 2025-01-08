// Description: Stack class
public class StackTraining {
    //criar empty constructor
    public StackTraining () { }

    public void HexadecimalConverter (int number) {

        string hexBase = "0123456789ABCDEF";
        string hexresult = "";
        string stackBuilding = "";

        for (int i = 0; i < number; i++) {
            int remainder = number % 16;
            stackBuilding += hexBase[remainder].ToString ();
            number = number / 16;
        }
        for (int i = stackBuilding.Length - 1; i >= 0; i--) {
            hexresult += stackBuilding[i];
        }

        Console.WriteLine ($"Resultado: {hexresult}");
    }

}