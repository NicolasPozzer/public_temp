using System.Collections;

namespace Unidad4PozzerOteroNaranjoSosaTis;

/*
    Integrantes del Grupo "Byte Builders":
    -   Jose Nicolas Pozzer -   
    -   Ignacio Otero       -   
    -   Noheli Naranjo Vega -   
    -   Ignacio Sosa        -   
    -   Maximiliano Tis     -   
*/
class Program
{
    static void Main(string[] args)
    {
        /*
         *  2- Crear una función que muestre un mensaje pasado como parámetro y utilizarla en todos los puntos del ejercicio.
         *  3- Crear una función que pida la altura en centímetros de 5 personas guardando en un arreglo los valores,
         *      luego recorrer el arreglo y mostrar el mas alto y el mas bajo.
         *  4- Hacer una función que ingresen las notas de los alumnos y los guarde en un ArrayList. Luego calcular y
         *      mostrar el promedio, nota máxima y mínima.
         *  5- Hacer una función que actúe como un diccionario en donde el usuario ingresa una palabra y nos devuelve
         *      la definición usando la colección Hashtable (inicializar con al menos 5 palabras).
         *  6- Hacer un función que le solicite al usuario 4 números y luego los muestre en orden descendente.
         */
        
        //Mensaje("Test");
        //SolicitarAlturas();
        //SolicitarYCalcularNotas();
        DiccionarioPalabras();
        OrdenarNumerosDescendente();


    }

    public static void Mensaje(string mensaje)
    {
        Console.WriteLine(mensaje);
    }
    
    // PUNTO 3
    public static void SolicitarAlturas()
    {
        ArrayList alturas = new ArrayList();
        int altura_maxima = 0;
        int altura_minima = 300;

        // pedir medidas
        for (int i = 1; i <= 5; i++)
        {
            Mensaje("Ingrese la altura de la persona Nro. " + i + ": ");
            string input = Console.ReadLine();
            int numero = int.Parse(input);
            
            alturas.Add(numero);
        }
        
        // calcular y recorrer medidas
        foreach (int item in alturas)
        {
            
            if (item > altura_maxima)
            {
                altura_maxima = item;
            }
            if (item < altura_minima)
            {
                altura_minima = item;
            }
        }
        Mensaje("La altura Maxima Registrada es: " + altura_maxima + "cm");
        Mensaje("La altura Minima Registrada es: " + altura_minima + "cm");
    }
    
    // PUNTO 4
    public static void SolicitarYCalcularNotas()
    {
        ArrayList notas = new ArrayList();
        float nota_maxima = 0;
        float nota_minima = 100;
        float acum_notas = 0;
        float promedio = 0;

        bool terminar = false;
        // pedir medidas
        while (!terminar)
        {
            Mensaje("Ingrese la Nota del Alumno: ");
            string input = Console.ReadLine();
            float numero = float.Parse(input);
            
            notas.Add(numero);
            
            // pregunta para terminar bucle de ingreso notas
            Mensaje("Desea ingresar otra nota? s = Si, n = No");
            string pregunta = Console.ReadLine();
            if (pregunta == "n" || pregunta == "N" || pregunta == "no" || pregunta == "No")
            {
                terminar = true;
            }
        }
        
        // calcular y recorrer medidas
        foreach (float item in notas)
        {
            // acumulamos notas, que luego nos servira para calcular promedio
            acum_notas = acum_notas + item;
            if (item > nota_maxima)
            {
                nota_maxima = item;
            }
            if (item < nota_minima)
            {
                nota_minima = item;
            }
        }
        
        // calculamos el promedio
        promedio = acum_notas / notas.Count;
        
        Mensaje("La Nota Maxima Registrada es: " + nota_maxima);
        Mensaje("La Nota Minima Registrada es: " + nota_minima);
        Mensaje("El promedio obtenido de las " + notas.Count + " Notas es: " + promedio.ToString("0.00"));
    }
    
    // PUNTO 5
    public static void DiccionarioPalabras()
    {
        Hashtable diccionario = new Hashtable();
        
        // agregamos los 5 ejemplos
        diccionario.Add("backend", "Parte logica de una aplicacion");
        diccionario.Add("frontend", "Parte visual de una aplicacion");
        diccionario.Add("cpu", "Procesador principal de la computadora");
        diccionario.Add("ram", "Memoria temporal del sistema");
        diccionario.Add("ssd", "Unidad de almacenamiento rapido");

        Mensaje("Ingrese una palabra para buscar su definicion:");
        string palabra = Console.ReadLine().ToLower();

        // condicional para obtener resultado del input
        if (diccionario.ContainsKey(palabra))
        {
            Mensaje("Definicion: " + diccionario[palabra]);
        }
        else
        {
            Mensaje("La palabra no existe en el diccionario");
        }
    }

    // PUNTO 6
    public static void OrdenarNumerosDescendente()
    {
        ArrayList numeros = new ArrayList();

        for (int i = 1; i <= 4; i++)
        {
            Mensaje("Ingrese el numero Nro. " + i + ": ");
            string input = Console.ReadLine();

            int numero = int.Parse(input);

            numeros.Add(numero);
        }

        numeros.Sort();
        numeros.Reverse();

        Mensaje("Numeros ordenados de mayor a menor:");

        foreach (var item in numeros)
        {
            Mensaje(item.ToString());
        }
    }
}
















