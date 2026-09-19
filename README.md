# Arreglos y matrices

Consola con la misma lógica en Python y C#: gestión de un arreglo de 10 enteros y de una matriz 3x3.

## Requisitos

- Python 3 (solo biblioteca estándar)
- .NET SDK 8.0 o superior (para la versión C#)

No hay base de datos, dependencias extra ni variables de entorno.

## Ejecutar

### Python

Desde la carpeta `python/`:

```
python main.py
```

### C#

Desde la carpeta `csharp/` (el punto de entrada es `Program.cs`):

```
dotnet run
```

## Cómo probar

Menú principal:

1. Gestión de Arreglos
2. Gestión de Matrices
0. Salir

Hay que crear el arreglo o la matriz (opción 1 de cada submenú) antes de usar el resto de opciones.

**Arreglos:** crea 10 enteros aleatorios (1–100). Luego puedes mostrarlos (for clásico o for-each), cambiar impares por 0, multiplicar por el índice y buscar un valor (escribe un entero; si no está, indica que no se encontró).

**Matrices:** crea una 3x3 con valores 1 a 9, la muestra como tabla y la recorre por columnas. Luego puedes sumar elementos (debe dar 45) o intercambiar la primera y la última fila.
