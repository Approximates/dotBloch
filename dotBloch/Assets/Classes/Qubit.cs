using UnityEngine;
using System.Numerics;
using System;
public class Qubit 
{
    private double _phiAngle;
    private double _thetaAngle;

    private PrintQubit print;

    private Complex[] quantumValue = new Complex[2];

    public Qubit(double thetaAngle, double phiAngle)
    {
        if(validate.angles(thetaAngle,phiAngle)){
            this._thetaAngle = thetaAngle;
            this._phiAngle = phiAngle;

            this.update_quantum_zero_value();
            this.update_quantum_one_value();

            this.print = new PrintQubit();
        }
        else
        {
            Debug.Log(Constants.error.angle_is_wrong);
            throw new ArgumentException(Constants.error.angle_is_wrong);      
        }
    }

#region geters_and_setters
    public double phiAngle
    {
        get 
        {
            return _phiAngle;
        }
        set
        {
            if(validate.phi_angle(value))
            {
                _phiAngle = value;
                this.update_quantum_one_value();
            }
            else{
                Debug.Log("Value of theta or phi angle is wrong");
            }
        }
    }

    public double thetaAngle
    {
        get
        {
            return _thetaAngle;
        }
        set
        {
            if(validate.theta_angle(value)){
                _thetaAngle = value;
                this.update_quantum_zero_value();
                this.update_quantum_one_value();
            }
        }
    }
    #endregion

#region value_updates
    private void update_quantum_zero_value(){
        this.quantumValue[0] = new Complex(Math.Cos(StaticMethods.degree_to_radian(this.thetaAngle)/2),0);
    }

    private void update_quantum_one_value(){
        double cos_phi_ = Math.Cos(StaticMethods.degree_to_radian(this.phiAngle));
        double sin_theta_div_2_ = Math.Sin(StaticMethods.degree_to_radian(this.thetaAngle)/2);
        double sin_phi = Math.Sin(StaticMethods.degree_to_radian(this.phiAngle));

        this.quantumValue[1] = new Complex(cos_phi_*sin_theta_div_2_,sin_phi*sin_theta_div_2_);
    }

#endregion

#region printing
    public string print_bloch_vector(PrintBlochSettings printingSettings = null){
        return print.bloch_vector(this.quantumValue,printingSettings);
    }
    
    public string print_zero_value(PrintBlochSettings printingSettings = null) {
        return print.quantum_value(quantumValue[0],printingSettings);
    }

    public string print_one_value(PrintBlochSettings printingSettings = null) {
        return print.quantum_value(quantumValue[1],printingSettings);
    }
#endregion
}
