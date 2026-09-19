def crear_matriz():
    matriz = []
    n = 1
    for i in range(3):
        fila = []
        for j in range(3):
            fila.append(n)
            n += 1
        matriz.append(fila)
    return matriz


def mostrar_como_tabla(matriz):
    for i in range(len(matriz)):
        linea = ""
        for j in range(len(matriz[i])):
            linea += str(matriz[i][j])
            if j < len(matriz[i]) - 1:
                linea += " "
        print(linea)


def recorrer_por_columnas(matriz):
    filas = len(matriz)
    columnas = len(matriz[0])
    for j in range(columnas):
        for i in range(filas):
            print(matriz[i][j])


def sumar_elementos(matriz):
    total = 0
    for i in range(len(matriz)):
        for j in range(len(matriz[i])):
            total += matriz[i][j]
    return total


def intercambiar_primera_y_ultima_fila(matriz):
    primera = matriz[0]
    matriz[0] = matriz[len(matriz) - 1]
    matriz[len(matriz) - 1] = primera
