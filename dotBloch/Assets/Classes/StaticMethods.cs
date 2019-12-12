using System;

class StaticMethods
{
    
    public static double degree_to_radian(double angle, int? decimalSpaces = null){
        return Math.PI * angle / 180.0;
    }
    
}

