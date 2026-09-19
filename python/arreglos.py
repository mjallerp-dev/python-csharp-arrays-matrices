import random

def crear_arreglo():
    return [random.randint(1, 100) for _ in range(10)]


def mostrar_con_for_clasico(arreglo):
    for i in range(len(arreglo)):
        print(f"[{i}] {arreglo[i]}")


def mostrar_con_for_each(arreglo):
    for valor in arreglo:
        print(valor)


def cambiar_impares_por_cero(arreglo):
    for i in range(len(arreglo)):
        if arreglo[i] % 2 != 0:
            arreglo[i] = 0


def multiplicar_por_indice(arreglo):
    for i in range(len(arreglo)):
        arreglo[i] *= i


def buscar_lineal(arreglo, valor):
    for i in range(len(arreglo)):
        if arreglo[i] == valor:
            return i
    return -1
