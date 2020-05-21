using UnityEngine;
using System.Numerics;
using System;
public class Qubit 
{
    private double _phiAngle;
    private double _thetaAngle;

    private PrintQubit print;

    private Complex[] quantumValue = new Complex[2];
    private Complex[,] density_matrix = new Complex[2,2];
    private double[] probability = new double[2];

    public Qubit(double thetaAngle, double phiAngle)
    {
        if(validate.angles(thetaAngle,phiAngle)){
            this._thetaAngle = thetaAngle;
            this._phiAngle = phiAngle;

            this.update_quantum_zero_value();
            this.update_quantum_one_value();
            this.update_density_matrix();
            this.update_probability();

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
                this.update_density_matrix();
                this.update_probability();
            }
            else{
                Debug.Log(Constants.error.angle_is_wrong);
            }
        }
    }

    public double this[int index]
    {
        get
        {
            return probability[index];
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
                this.update_density_matrix();
                this.update_probability();
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

    private void update_density_matrix(){
        density_matrix[0,0] = new Complex(Math.Pow(Math.Cos(StaticMethods.degree_to_radian(this.thetaAngle)/2),2),0);
        density_matrix[0,1] = new Complex(Math.Cos(-StaticMethods.degree_to_radian(this.phiAngle))*Math.Cos(StaticMethods.degree_to_radian(this.thetaAngle)/2)*Math.Sin(StaticMethods.degree_to_radian(this.thetaAngle)/2),Math.Sin(-StaticMethods.degree_to_radian(this.phiAngle))*Math.Cos(StaticMethods.degree_to_radian(this.thetaAngle)/2)*Math.Sin(StaticMethods.degree_to_radian(this.thetaAngle)/2));
        density_matrix[1,0] = new Complex(Math.Cos(StaticMethods.degree_to_radian(this.phiAngle))*Math.Cos(StaticMethods.degree_to_radian(this.thetaAngle)/2)*Math.Sin(StaticMethods.degree_to_radian(this.thetaAngle)/2),Math.Sin(StaticMethods.degree_to_radian(this.phiAngle))*Math.Cos(StaticMethods.degree_to_radian(this.thetaAngle)/2)*Math.Sin(StaticMethods.degree_to_radian(this.thetaAngle)/2));
        density_matrix[1,1] = new Complex(Math.Pow(Math.Sin(StaticMethods.degree_to_radian(this._thetaAngle)/2),2),0);
    }

    private void update_probability()
    {
        double theta_angle = StaticMethods.degree_to_radian(this.thetaAngle);
        double phi_angle = StaticMethods.degree_to_radian(this.phiAngle);

        Complex alfa = new Complex(Math.Cos(phi_angle)*Math.Cos(theta_angle/2),Math.Sin(phi_angle)*Math.Cos(theta_angle/2));
        Complex beta = new Complex(Math.Cos(theta_angle+phi_angle)*Math.Sin(theta_angle/2),Math.Sin(theta_angle+phi_angle)*Math.Sin(theta_angle/2));

        alfa = Complex.Multiply(alfa,alfa);
        beta = Complex.Multiply(beta,beta);

        this.probability[0] = Convert.ToDouble(alfa.Magnitude/(alfa.Magnitude+beta.Magnitude));
        this.probability[1] = Convert.ToDouble(beta.Magnitude/(alfa.Magnitude+beta.Magnitude));
    }


#endregion

#region printing
    public string print_bloch_vector(PrintBlochSettings printingSettings = null)
    {
        return print.bloch_vector(this.quantumValue,printingSettings);
    }
    
    public string print_zero_value(PrintBlochSettings printingSettings = null) {
        return print.quantum_value(quantumValue[0],printingSettings);
    }

    public string print_one_value(PrintBlochSettings printingSettings = null) {
        return print.quantum_value(quantumValue[1],printingSettings);
    }

    public string printDensityMatrix(int row, int column, PrintBlochSettings printingSettings = null){
        return print.quantum_value(density_matrix[row,column],printingSettings);
    }

    public string print_zero_probability(PrintBlochSettings printingSettings = null)
    {
        return print.percent_value(true,probability[0],printingSettings);
    }

    public string print_one_probability(PrintBlochSettings printingSettings = null)
    {
        return print.percent_value(false,probability[1],printingSettings);
    }
#endregion
}