using System;
using Arboles_Bin;

ArbolBB arbol = new ArbolBB();

// Insertar los valores del árbol
arbol.Insertar(15);
arbol.Insertar(9);
arbol.Insertar(6);
arbol.Insertar(14);
arbol.Insertar(13);
arbol.Insertar(20);
arbol.Insertar(17);
arbol.Insertar(64);
arbol.Insertar(26);
arbol.Insertar(72);

Console.WriteLine("Recorrido Preorden:");
arbol.Preorden();

Console.WriteLine("\nRecorrido Inorden:");
arbol.Inorden();

Console.WriteLine("\nRecorrido Postorden:");
arbol.Postorden();