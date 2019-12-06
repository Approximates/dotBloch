using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static PrintBlochSettings;

class validate
{
    public static bool angles(double thetaAngle, double phiAngle){
        if(theta_angle(thetaAngle) && phi_angle(phiAngle))
            return true;
        else 
            return false;
    }

    public static bool theta_angle(double angle){
        if(angle >=0 && angle<=180)
            return true;
        else
            return false;
    }

    public static bool phi_angle(double angle){
        if(angle >=0 && angle<=360)
            return true;
        else
            return false;
    }
}

