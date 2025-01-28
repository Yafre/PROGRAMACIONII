using System;
using System.Globalization;

namespace CalculoSalario
{
    class Program
    {
        public abstract class Empleado
        {
            public string Nombre { get; set; }

            public abstract double CalcularSalario();
        }

        public class DocentePorHora : Empleado
        {
            public int HorasTrabajadas { get; set; }
            public const double TarifaPorHora = 800;

            public override double CalcularSalario()
            {
                return HorasTrabajadas * TarifaPorHora;
            }
        }

        public class DocenteContratoFijo : Empleado
        {
            public double SalarioBase { get; set; }
            public bool MetaAlcanzada { get; set; }

            public override double CalcularSalario()
            {
                return MetaAlcanzada ? SalarioBase : SalarioBase / 2;
            }
        }

        public class EmpleadoAdministrativo : Empleado
        {
            public double SalarioBase { get; set; }
            public bool MetaAlcanzada { get; set; }

            public override double CalcularSalario()
            {
                return MetaAlcanzada ? SalarioBase : SalarioBase / 2;
            }
        }

        static void Main(string[] args)
        {
            CultureInfo culture = new CultureInfo("es-DO");
            CultureInfo.DefaultThreadCurrentCulture = culture;
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            Console.WriteLine("=== Sistema de Cálculo de Salarios ===\n");

            DocentePorHora docenteHora = new DocentePorHora
            {
                Nombre = "Yafreisy Alvarez",
                HorasTrabajadas = 50
            };

            DocenteContratoFijo docenteFijo = new DocenteContratoFijo
            {
                Nombre = "Jahisy Peguero",
                SalarioBase = 40000,
                MetaAlcanzada = true
            };

            EmpleadoAdministrativo admin = new EmpleadoAdministrativo
            {
                Nombre = "Yunior Feliciano",
                SalarioBase = 30000,
                MetaAlcanzada = false
            };

            Console.WriteLine($"Empleado: {docenteHora.Nombre}\nTipo: Docente por Hora\nSalario: {docenteHora.CalcularSalario():N0} RD$\n");
            Console.WriteLine($"Empleado: {docenteFijo.Nombre}\nTipo: Docente de Contrato Fijo\nSalario: {docenteFijo.CalcularSalario():N0} RD$\n");
            Console.WriteLine($"Empleado: {admin.Nombre}\nTipo: Administrativo\nSalario: {admin.CalcularSalario():N0} RD$\n");

            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
