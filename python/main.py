from python.arreglos import (
    buscar_lineal,
    cambiar_impares_por_cero,
    crear_arreglo,
    mostrar_con_for_clasico,
    mostrar_con_for_each,
    multiplicar_por_indice,
)
from matrices import (
    crear_matriz,
    intercambiar_primera_y_ultima_fila,
    mostrar_como_tabla,
    recorrer_por_columnas,
    sumar_elementos,
)


def menu_arreglos(arreglo, creado):
    volver = False
    while not volver:
        print()
        print("Gestión de Arreglos")
        print("1. Crear arreglo (10 enteros aleatorios)")
        print("2. Mostrar con for clásico")
        print("3. Mostrar con for-each")
        print("4. Cambiar impares por cero")
        print("5. Multiplicar por índice")
        print("6. Búsqueda lineal")
        print("0. Volver")
        opcion = input("Opción: ").strip()

        if opcion == "1":
            arreglo = crear_arreglo()
            creado = True
            print("Arreglo creado.")
        elif opcion == "0":
            volver = True
        elif not creado:
            print("Primero debe crear el arreglo.")
        elif opcion == "2":
            mostrar_con_for_clasico(arreglo)
        elif opcion == "3":
            mostrar_con_for_each(arreglo)
        elif opcion == "4":
            cambiar_impares_por_cero(arreglo)
            print("Impares cambiados por cero.")
        elif opcion == "5":
            multiplicar_por_indice(arreglo)
            print("Valores multiplicados por su índice.")
        elif opcion == "6":
            entrada = input("Valor a buscar: ").strip()
            try:
                valor = int(entrada)
                indice = buscar_lineal(arreglo, valor)
                if indice >= 0:
                    print(f"Encontrado en el índice {indice}")
                else:
                    print("No se encontró el valor")
            except ValueError:
                print("Debe ingresar un número entero.")
        else:
            print("Opción no válida.")

    return arreglo,
