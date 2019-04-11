using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Persona
    {
        string nombre;
        int diaNacimiento;
        int mesNacimiento;
        int anioNacimineto;
        int edad;

        public int Edad { get => edad; set => edad = value; }
        public int AnioNacimineto { get => anioNacimineto; set => anioNacimineto = value; }
        public int DiaNacimiento { get => diaNacimiento; set => diaNacimiento = value; }


    }

}
