using UnityEngine;
public class Constants
{
    public static class symbol{

        public const string bloch_sphere = "|Ψ> = ";
        public const string quantum_one = " |1>";
        public const string quantum_zero = " |0> ";      
    }

    public static class quantum_probability{
        public const string zero_label = "P(|0>) = ";
        public const string one_label = "P(|1>) = ";
    }

    public static class error{
        public const string angle_is_wrong = "Value of theta or phi angle is wrong";
    }

    public static class character{
        public const string space = " ";
        public const string dot = ".";
        public const string comma = ",";

        public const string percent = "%";

        public const string rounding_header = "N";
    }

    public static class math{
        public const string minus = "-";
        public const string plus_with_space = "+ ";
        public const string minus_with_space = "- ";
    }

    public static class message{
        public const string exit_question = "Do you want to close the app?";
    }

    public static class latex{
        public const string zeroAndOneFormula_1 = @"\begin{bmatrix}\:|0>\:\\\:|1>\: \end{bmatrix}=\begin{bmatrix}\: \cos({\frac{\theta}{2}})\:\\\:e^{i\phi}*\sin({\frac{\theta}{2}})\: \end{bmatrix}=\begin{bmatrix}\:";
        public const string zeroAndOneFormula_2 = @"\:\\\:";
        public const string zeroAndOneFormula_3 = @"\:\end{bmatrix}";

        public const string densityMatrixFormula = @"\rho = \begin{pmatrix}{\tiny \cos^2{\frac{\theta}{2}}} & e^{-i\phi}\cos{\frac{\theta}{2}}\sin{\frac{\theta}{2}}  \\e^{i\phi}\cos{\frac{\theta}{2}}\sin{\frac{\theta}{2}} &\sin^2{\frac{\theta}{2}} \end{pmatrix}";

        public const string densityMatrixValues = @"";

        public const string densityMatrixWhole_1 = @"\rho = \begin{pmatrix}{\tiny \cos^2{\frac{\theta}{2}}} & e^{-i\phi}\cos{\frac{\theta}{2}}\sin{\frac{\theta}{2}}  \\e^{i\phi}\cos{\frac{\theta}{2}}\sin{\frac{\theta}{2}} &\sin^2{\frac{\theta}{2}} \end{pmatrix}=\begin{pmatrix}";
        public const string densityMatrixWhole_2 = @" & ";
        public const string densityMatrixWhole_3 = @"  \\";
        public const string densityMatrixWhole_4 = @" & ";
        public const string densityMatrixWhole_5 = @"\end{pmatrix}";
    }
}

