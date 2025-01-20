using Escuela_Ejercicio1;

class Program
{
    static void Main(string[] args)
    {

        // Clase CienciasBasicas
        Clase cienciasBasicas = new Clase("CienciasBasicas", "CB001");
        cienciasBasicas.AgregarEstudiante(new Estudiante("Yafreisy Alvarez", "01"));
        cienciasBasicas.AgregarEstudiante(new Estudiante("Emelin Capellan", "02"));

        Profesor eladioGonzales = new Profesor("Eladio Gonzales");
        eladioGonzales.AgregarCurso(new Curso("Estadística", 12, 10));
        eladioGonzales.AgregarCurso(new Curso("Cálculo Integral", 14, 8));

        Profesor dalitzaFelix = new Profesor("Dalitza Felix");
        dalitzaFelix.AgregarCurso(new Curso("Estadística Avanzada", 10, 15));
        dalitzaFelix.AgregarCurso(new Curso("Cálculo Diferencial", 11, 12));

        cienciasBasicas.AgregarProfesor(eladioGonzales);
        cienciasBasicas.AgregarProfesor(dalitzaFelix);

        // Clase Humanidades
        Clase humanidades = new Clase("Humanidades", "HUM001");
        humanidades.AgregarEstudiante(new Estudiante("Wandry Alvarez", "21"));
        humanidades.AgregarEstudiante(new Estudiante("Wendy Capellan", "05"));

        Profesor griseldaConcepcion = new Profesor("Griselda Concepción");
        griseldaConcepcion.AgregarCurso(new Curso("Historia Universal", 10, 7));
        griseldaConcepcion.AgregarCurso(new Curso("Filosofía", 8, 5));

        Profesor dawrinPeguero = new Profesor("Dawrin Peguero");
        dawrinPeguero.AgregarCurso(new Curso("Historia Dominicana", 9, 6));
        dawrinPeguero.AgregarCurso(new Curso("Ética", 6, 4));

        humanidades.AgregarProfesor(griseldaConcepcion);
        humanidades.AgregarProfesor(dawrinPeguero);

        cienciasBasicas.ImprimirInformacion();
        Console.WriteLine("\n-----------------------------------------------------\n");
        humanidades.ImprimirInformacion();
    }
}


