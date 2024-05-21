using System.ComponentModel.DataAnnotations.Schema;

namespace spaceEmpleado
{
    public enum Cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

    public class empleado
    {
        private DateTime hoy = DateTime.Now;

        public empleado(string nom,string ape, DateTime nacimiento, char civil, DateTime ingreso, double sueldo, Cargos cargo)
        {
            if ((DateTime.Compare(nacimiento,ingreso) < 0) && (DateTime.Compare(nacimiento,hoy) < 0))
            {
                nombre = nom;
                apellido = ape;
                fechaNacimiento = nacimiento;
                estadoCivil = civil;
                fechaIngreso = ingreso;
                sueldoBase = sueldo;
                this.cargo  = cargo;
            }
        }

        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private char estadoCivil;
        private DateTime fechaIngreso;
        private double sueldoBase;
        private Cargos cargo;
    }
}