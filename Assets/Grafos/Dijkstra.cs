using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dijkstra : MonoBehaviour
{
     List <Node> Grafo = new List<Node>();

     Queue pendientes = new Queue();
    void Start()
    {
        Grafo.Add(Node.addConection("A"));
        Grafo.Add(Node.addConection("B"));
        Grafo.Add(Node.addConection("C"));
        Grafo.Add(Node.addConection("D"));
        Grafo.Add(Node.addConection("E"));
        Grafo.Add(Node.addConection("F"));
        Grafo.Add(Node.addConection("G"));

        //For del infinito
        for(int i = 0; i < Grafo.Count; i++)
        {
            Grafo[i].peso = int.MaxValue;
        }

        //Añadiendo las conexiones
            //A
        Grafo[0].datos.Add(new Node.info(Grafo[2], 6));
        Grafo[0].datos.Add(new Node.info(Grafo[3], 4));
            //B
        Grafo[1].datos.Add(new Node.info(Grafo[0], 9));
            //C
        Grafo[2].datos.Add(new Node.info(Grafo[3], 9));
            //D
        Grafo[3].datos.Add(new Node.info(Grafo[1], 5));
        Grafo[3].datos.Add(new Node.info(Grafo[4], 6));
        Grafo[3].datos.Add(new Node.info(Grafo[5], 5));
        Grafo[3].datos.Add(new Node.info(Grafo[6], 8));
            //E
        Grafo[4].datos.Add(new Node.info(Grafo[1], 6));
        Grafo[4].datos.Add(new Node.info(Grafo[6], 1));
            //F
        Grafo[5].datos.Add(new Node.info(Grafo[2], 1));
            //G
        Grafo[6].datos.Add(new Node.info(Grafo[5], 9));

        //Asignacion del nodo raiz
        Node temp = Grafo[0];
        temp.peso = 0;
        temp.Visitado = true;

        do
        {
            Debug.Log("Estoy en :" + temp.nombre);
            for(int j = 0; j < temp.datos.Count; j++)
            {
                if(temp.datos[j].distancia + temp.peso < temp.datos[j].nodo.peso)
                {
                    temp.datos[j].nodo.Padre = temp;
                    Debug.Log("El nodo "  + temp.datos[j].nodo.nombre + " su padre ahora es: " + temp.nombre);
                    temp.datos[j].nodo.peso = temp.datos[j].distancia + temp.peso;
                    Debug.Log("El nodo "  + temp.datos[j].nodo.nombre + " su nuevo peso es: " + temp.datos[j].nodo.peso);
                }
                if(!temp.datos[j].nodo.Visitado)
                    pendientes.Enqueue(temp.datos[j].nodo);
                Debug.Log("Agregando: " + temp.datos[j].nodo.nombre + " a la cola");
            }
            temp = (Node)pendientes.Dequeue();
            Debug.Log("Se a quitado el nodo " + temp.nombre + " de la cola");
            temp.Visitado = true;
            Debug.Log("El valor del queue es de: " + pendientes.Count);
        } while (pendientes.Count != 0);

        temp = Grafo[5];

         while(temp.Padre != null)
        {
            Debug.Log(temp.nombre);
            temp = temp.Padre;
        }
        Debug.Log(temp.nombre);
    }
}
