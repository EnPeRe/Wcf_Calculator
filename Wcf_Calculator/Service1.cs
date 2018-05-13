using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Wcf_Calculator
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class Service1 : IService1
    {
        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Substract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
