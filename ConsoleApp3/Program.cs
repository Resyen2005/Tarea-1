
public class POO_CSharp
{
    // Abstracción: Definimos una clase base con métodos abstractos
    abstract class Persona
    {
        protected string nombre; // Encapsulamiento: Se usa 'protected' para restringir acceso

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public abstract void MostrarRol(); // Método abstracto (se implementa en las subclases)
    }

    // Herencia: Estudiante hereda de Persona
    class Estudiante : Persona
    {
        private int carnet; // Encapsulamiento

        public Estudiante(string nombre, int carnet) : base(nombre)
        {
            this.carnet = carnet;
        }

        // Polimorfismo: Implementamos el método de la clase base con un comportamiento específico
        public override void MostrarRol()
        {
            Console.WriteLine($"Soy {nombre} y soy un estudiante con carnet {carnet}.");
        }
    }

    // Herencia: Profesor hereda de Persona
    class Profesor : Persona
    {
        private string materia; // Encapsulamiento

        public Profesor(string nombre, string materia) : base(nombre)
        {
            this.materia = materia;
        }

        public override void MostrarRol()
        {
            Console.WriteLine($"Soy {nombre} y enseño {materia}.");
        }
    }

    class Program
    {
        // Diferencia entre variables por valor y referencia
        static void CambiarValor(int numero)
        {
            numero = 20; // No afecta la variable original
        }

        static void CambiarReferencia(ref int numero)
        {
            numero = 30; // Modifica la variable original
        }

        static void Main()
        {
            // Variables por valor y referencia
            int valor = 10;
            CambiarValor(valor);
            Console.WriteLine($"Variable por valor: {valor}"); // Sigue siendo 10

            int referencia = 10;
            CambiarReferencia(ref referencia);
            Console.WriteLine($"Variable por referencia: {referencia}"); // Ahora es 30

            // Crear objetos y demostrar POO
            Persona estudiante = new Estudiante("Carlos", 12345);
            Persona profesor = new Profesor("Ana", "Programación");

            estudiante.MostrarRol();
            profesor.MostrarRol();
        }
    }
}
