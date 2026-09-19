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
