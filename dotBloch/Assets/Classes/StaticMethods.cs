using System;

public class StaticMethods
{
    
    public static double degree_to_radian(double angle, int? decimalSpaces = null){
        return Math.PI * angle / 180.0;
    }

    public static string exitText = "Do you want to close the app?";

}

