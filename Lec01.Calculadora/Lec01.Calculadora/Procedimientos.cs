using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lec01.Calculadora
{
    public class Procedimientos
    {
        public String RealizarOperacion(String txtNum1, String txtNum2, String cmbOperaciones)
        {
            double num1 = (Convert.ToDouble(txtNum1));
            double num2 = (Convert.ToDouble(txtNum2));
            String op = cmbOperaciones;
            String Resultado = Calcular(num1,num2,op).ToString();
            return Resultado;
        }
        public double Calcular(double num1,double num2, string op)
        {
            double Resultado = 0.0;
            switch (op)
            {
                case "Suma":
                    Resultado = num1 + num2;
                    break;
                case "Resta":
                    Resultado = num1 - num2;
                    break;
                case "Multiplicacion":
                    Resultado= num1*num2;
                    break;
                case "Division":
                    if (num2 != 0)
                    {
                        Resultado = num1 / num2;
                    }
                    else
                    {
                        Resultado = 0.0;
                    }
                    break;

            }
            return Resultado;
        }
    }
}
