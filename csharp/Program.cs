using System;

public class Program{

    public static void Main() {
        int[]? arreglo = null;
        int[,]? matriz = null;
        bool arregloCreado = false;
        bool matrizCreada = false;
        bool salir = false;

        while (!salir) {
            Console.WriteLine();
            Console.WriteLine("1. Gestión de Arreglos");
            Console.WriteLine("2. Gestión de Matrices");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");
            string opcion = (Console.ReadLine() ?? "").Trim();

            if (opcion == "1") {
                (arreglo, arregloCreado) = MenuArreglos(arreglo, arregloCreado);
            }
            else if (opcion == "2") {
                (matriz, matrizCreada) = MenuMatrices(matriz, matrizCreada);
            }
            else if (opcion == "0") {
                salir = true;
            }
            else {
                Console.WriteLine("Opción no válida.");
            }
        }
    }

    private static (int[]? arreglo, bool creado) MenuArreglos(int[]? arreglo, bool creado) {
        bool volver = false;
        while (!volver) {
            Console.WriteLine();
            Console.WriteLine("Gestión de Arreglos");
            Console.WriteLine("1. Crear arreglo (10 enteros aleatorios)");
            Console.WriteLine("2. Mostrar con for clásico");
            Console.WriteLine("3. Mostrar con for-each");
            Console.WriteLine("4. Cambiar impares por cero");
            Console.WriteLine("5. Multiplicar por índice");
            Console.WriteLine("6. Búsqueda lineal");
            Console.WriteLine("0. Volver");
            Console.Write("Opción: ");
            string opcion = (Console.ReadLine() ?? "").Trim();

            if (opcion == "1") {
                arreglo = Arreglos.CrearArreglo();
                creado = true;
                Console.WriteLine("Arreglo creado.");
            }
            else if (opcion == "0") {
                volver = true;
            }
            else if (!creado || arreglo == null) {
                Console.WriteLine("Primero debe crear el arreglo.");
            }
            else if (opcion == "2") {
                Arreglos.MostrarConForClasico(arreglo);
            }
            else if (opcion == "3") {
                Arreglos.MostrarConForEach(arreglo);
            }
            else if (opcion == "4") {
                Arreglos.CambiarImparesPorCero(arreglo);
                Console.WriteLine("Impares cambiados por cero.");
            }
            else if (opcion == "5") {
                Arreglos.MultiplicarPorIndice(arreglo);
                Console.WriteLine("Valores multiplicados por su índice.");
            }
            else if (opcion == "6") {
                Console.Write("Valor a buscar: ");
                string entrada = (Console.ReadLine() ?? "").Trim();
                if (int.TryParse(entrada, out int valor)) {
                    int indice = Arreglos.BuscarLineal(arreglo, valor);
                    if (indice >= 0) {
                        Console.WriteLine($"Encontrado en el índice {indice}");
                    }
                    else {
                        Console.WriteLine("No se encontró el valor");
                    }
                }
                else {
                    Console.WriteLine("Debe ingresar un número entero.");
                }
            }
            else {
                Console.WriteLine("Opción no válida.");
            }
        }

        return (arreglo, creado);
    }

    private static (int[,]? matriz, bool creada) MenuMatrices(int[,]? matriz, bool creada) {
        bool volver = false;
        while (!volver) {
            Console.WriteLine();
            Console.WriteLine("Gestión de Matrices");
            Console.WriteLine("1. Crear matriz 3x3 (1 a 9)");
            Console.WriteLine("2. Sumar elementos");
            Console.WriteLine("3. Intercambiar primera y última fila");
            Console.WriteLine("0. Volver");
            Console.Write("Opción: ");
            string opcion = (Console.ReadLine() ?? "").Trim();

            if (opcion == "1") {
                matriz = Matrices.CrearMatriz();
                creada = true;
                Console.WriteLine("Matriz creada.");
                Matrices.MostrarComoTabla(matriz);
                Matrices.RecorrerPorColumnas(matriz);
            }
            else if (opcion == "2") {
                if (!creada || matriz == null) {
                    Console.WriteLine("Primero debe crear la matriz.");
                }
                else {
                    Console.WriteLine($"Suma de elementos: {Matrices.SumarElementos(matriz)}");
                }
            }
            else if (opcion == "3") {
                if (!creada || matriz == null) {
                    Console.WriteLine("Primero debe crear la matriz.");
                }
                else {
                    Matrices.IntercambiarPrimeraYUltimaFila(matriz);
                    Console.WriteLine("Primera y última fila intercambiadas.");
                    Matrices.MostrarComoTabla(matriz);
                }
            }
            else if (opcion == "0") {
                volver = true;
            }
            else {
                Console.WriteLine("Opción no válida.");
            }
        }

        return (matriz, creada);
    }
}
