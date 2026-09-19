using System;

public static class Matrices{

    public static int[,] CrearMatriz() {
        int[,] matriz = new int[3, 3];
        int n = 1;
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                matriz[i, j] = n;
                n++;
            }
        }
        return matriz;
    }

    public static void MostrarComoTabla(int[,] matriz) {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        for (int i = 0; i < filas; i++) {
            string linea = "";
            for (int j = 0; j < columnas; j++) {
                linea += matriz[i, j].ToString();
                if (j < columnas - 1) {
                    linea += " ";
                }
            }
            Console.WriteLine(linea);
        }
    }

    public static void RecorrerPorColumnas(int[,] matriz) {
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        for (int j = 0; j < columnas; j++) {
            for (int i = 0; i < filas; i++) {
                Console.WriteLine(matriz[i, j]);
            }
        }
    }

    public static int SumarElementos(int[,] matriz) {
        int total = 0;
        int filas = matriz.GetLength(0);
        int columnas = matriz.GetLength(1);
        for (int i = 0; i < filas; i++) {
            for (int j = 0; j < columnas; j++) {
                total += matriz[i, j];
            }
        }
        return total;
    }

    public static void IntercambiarPrimeraYUltimaFila(int[,] matriz) {
        int ultima = matriz.GetLength(0) - 1;
        int columnas = matriz.GetLength(1);
        for (int j = 0; j < columnas; j++) {
            int temp = matriz[0, j];
            matriz[0, j] = matriz[ultima, j];
            matriz[ultima, j] = temp;
        }
    }
}
