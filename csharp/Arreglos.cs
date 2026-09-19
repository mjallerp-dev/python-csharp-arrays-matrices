using System;

public static class Arreglos{

    public static int[] CrearArreglo() {
        int[] arreglo = new int[10];
        Random random = new Random();
        for (int i = 0; i < arreglo.Length; i++) {
            arreglo[i] = random.Next(1, 101);
        }
        return arreglo;
    }

    public static void MostrarConForClasico(int[] arreglo) {
        for (int i = 0; i < arreglo.Length; i++) {
            Console.WriteLine($"[{i}] {arreglo[i]}");
        }
    }

    public static void MostrarConForEach(int[] arreglo) {
        foreach (int valor in arreglo) {
            Console.WriteLine(valor);
        }
    }

    public static void CambiarImparesPorCero(int[] arreglo) {
        for (int i = 0; i < arreglo.Length; i++) {
            if (arreglo[i] % 2 != 0) {
                arreglo[i] = 0;
            }
        }
    }

    public static void MultiplicarPorIndice(int[] arreglo) {
        for (int i = 0; i < arreglo.Length; i++) {
            arreglo[i] *= i;
        }
    }

    public static int BuscarLineal(int[] arreglo, int valor) {
        for (int i = 0; i < arreglo.Length; i++) {
            if (arreglo[i] == valor) {
                return i;
            }
        }
        return -1;
    }
}
