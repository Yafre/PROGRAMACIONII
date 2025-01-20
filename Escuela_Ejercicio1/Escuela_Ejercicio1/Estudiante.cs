namespace Escuela_Ejercicio1
{
    public class Estudiante : Persona
    {
        public string Numero { get; set; }

        public Estudiante(string nombre, string numero) : base(nombre)
        {
            Numero = numero;
        }
    }
}
