using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BFS : MonoBehaviour
{
    List <Node> Grafo = new List<Node>();
    Queue pendientes;
    // Start is called before the first frame update
    void Start()
    {
        ///Añadiendo los nodos al grafo
        Grafo.Add(Node.addConection("A"));
        Grafo.Add(Node.addConection("B"));
        Grafo.Add(Node.addConection("C"));
        Grafo.Add(Node.addConection("D"));
        Grafo.Add(Node.addConection("E"));
        Grafo.Add(Node.addConection("F"));
        Grafo.Add(Node.addConection("G"));
        Grafo.Add(Node.addConection("H"));

        //Añadiendo las conexiones
            //A
        Grafo[0].conexiones.Add(Grafo[1]);
            //B
        Grafo[1].conexiones.Add(Grafo[0]);
        Grafo[1].conexiones.Add(Grafo[2]);
        Grafo[1].conexiones.Add(Grafo[4]);
            //C
        Grafo[2].conexiones.Add(Grafo[5]);
        Grafo[2].conexiones.Add(Grafo[1]);
            //D
        Grafo[3].conexiones.Add(Grafo[4]);
        Grafo[3].conexiones.Add(Grafo[6]);
            //E
        Grafo[4].conexiones.Add(Grafo[1]);
        Grafo[4].conexiones.Add(Grafo[3]);
        Grafo[4].conexiones.Add(Grafo[5]);
        Grafo[4].conexiones.Add(Grafo[7]);
            //F
        Grafo[5].conexiones.Add(Grafo[2]);
        Grafo[5].conexiones.Add(Grafo[4]);
        Grafo[5].conexiones.Add(Grafo[7]);
            //G
        Grafo[6].conexiones.Add(Grafo[3]);
        Grafo[6].conexiones.Add(Grafo[7]);
            //H
        Grafo[7].conexiones.Add(Grafo[4]);
        Grafo[7].conexiones.Add(Grafo[5]);
        Grafo[7].conexiones.Add(Grafo[6]);

        pendientes = new Queue();

        Node temp = Grafo[2];
        temp.Padre = Grafo[2];

        do
        {
            for(int i = 0; i < temp.conexiones.Count; i++)
            {
                if(temp.conexiones[i].Padre == null)
                    temp.conexiones[i].Padre = temp;
                pendientes.Enqueue(temp.conexiones[i]);
            }
        
            temp = (Node)pendientes.Dequeue();
        } while (temp != Grafo[6]);

        while(temp != temp.Padre)
        {
            Debug.Log(temp.nombre);
            temp = temp.Padre;
        }
        Debug.Log(temp.nombre);
    }
}
