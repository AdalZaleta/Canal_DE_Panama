using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Power_Greed : MonoBehaviour
{
    public int inicio;
    public int objetivo;

    List <Node> Grafo = new List<Node>();

     Queue pendientes = new Queue();
    void Start()
    {
        //Añadir los nodos
        Grafo.Add(Node.addConection("Seatle"));
        Grafo.Add(Node.addConection("Portland"));
        Grafo.Add(Node.addConection("San Francisco"));
        Grafo.Add(Node.addConection("Los Angeles"));
        Grafo.Add(Node.addConection("San Diego"));
        Grafo.Add(Node.addConection("Las Vegas"));
        Grafo.Add(Node.addConection("Phoenix"));
        Grafo.Add(Node.addConection("Boise"));
        Grafo.Add(Node.addConection("Salt Lake City"));
        Grafo.Add(Node.addConection("Santa Fe"));
        Grafo.Add(Node.addConection("Billings"));
        Grafo.Add(Node.addConection("Denver"));
        Grafo.Add(Node.addConection("Cheyenne"));
        Grafo.Add(Node.addConection("Fargo"));
        Grafo.Add(Node.addConection("Duluth"));
        Grafo.Add(Node.addConection("Minneapolis"));
        Grafo.Add(Node.addConection("Omaha"));
        Grafo.Add(Node.addConection("Kansas City"));
        Grafo.Add(Node.addConection("Chicago"));
        Grafo.Add(Node.addConection("ST. Louis"));
        Grafo.Add(Node.addConection("Oklahoma City"));
        Grafo.Add(Node.addConection("Dallas"));
        Grafo.Add(Node.addConection("Houston"));
        Grafo.Add(Node.addConection("Memphis"));
        Grafo.Add(Node.addConection("New Orlleans"));
        Grafo.Add(Node.addConection("Miami"));
        Grafo.Add(Node.addConection("Tampa"));
        Grafo.Add(Node.addConection("Jacksonville"));
        Grafo.Add(Node.addConection("Savannah"));
        Grafo.Add(Node.addConection("Atlanta"));
        Grafo.Add(Node.addConection("Knoxville"));
        Grafo.Add(Node.addConection("Washington"));
        Grafo.Add(Node.addConection("Cincinnati"));
        Grafo.Add(Node.addConection("Detroit"));
        Grafo.Add(Node.addConection("Buffalo"));
        Grafo.Add(Node.addConection("Pittsburg"));
        Grafo.Add(Node.addConection("Norfolk"));
        Grafo.Add(Node.addConection("Philadelphia"));
        Grafo.Add(Node.addConection("New York"));
        Grafo.Add(Node.addConection("Boston"));
        Grafo.Add(Node.addConection("Raleigh"));
        Grafo.Add(Node.addConection("Birmincham"));

        //For del infinito
        for(int i = 0; i < Grafo.Count; i++)
        {
            Grafo[i].peso = int.MaxValue;
        }

        //Añadiendo conexiones
            //1
        Grafo[0].datos.Add(new Node.info(Grafo[1], 3));
        Grafo[0].datos.Add(new Node.info(Grafo[7], 12));
        Grafo[0].datos.Add(new Node.info(Grafo[10], 9));
            //2
        Grafo[1].datos.Add(new Node.info(Grafo[0], 3));
        Grafo[1].datos.Add(new Node.info(Grafo[2], 24));
        Grafo[1].datos.Add(new Node.info(Grafo[7], 13));
            //3
        Grafo[2].datos.Add(new Node.info(Grafo[1], 24));
        Grafo[2].datos.Add(new Node.info(Grafo[3], 9));
        Grafo[2].datos.Add(new Node.info(Grafo[5], 14));
        Grafo[2].datos.Add(new Node.info(Grafo[7], 23));
        Grafo[2].datos.Add(new Node.info(Grafo[8], 27));
            //4
        Grafo[3].datos.Add(new Node.info(Grafo[2], 9));
        Grafo[3].datos.Add(new Node.info(Grafo[4], 3));
        Grafo[3].datos.Add(new Node.info(Grafo[5], 9));
            //5
        Grafo[4].datos.Add(new Node.info(Grafo[3], 3));
        Grafo[4].datos.Add(new Node.info(Grafo[5], 9));
        Grafo[4].datos.Add(new Node.info(Grafo[6], 14));
            //6
        Grafo[5].datos.Add(new Node.info(Grafo[2], 14));
        Grafo[5].datos.Add(new Node.info(Grafo[3], 9));
        Grafo[5].datos.Add(new Node.info(Grafo[4], 9));
        Grafo[5].datos.Add(new Node.info(Grafo[6], 15));
        Grafo[5].datos.Add(new Node.info(Grafo[8], 18));
        Grafo[5].datos.Add(new Node.info(Grafo[9], 27));
            //7
        Grafo[6].datos.Add(new Node.info(Grafo[4], 14));
        Grafo[6].datos.Add(new Node.info(Grafo[5], 15));
        Grafo[6].datos.Add(new Node.info(Grafo[9], 18));
            //8
        Grafo[7].datos.Add(new Node.info(Grafo[0], 12));
        Grafo[7].datos.Add(new Node.info(Grafo[1], 13));
        Grafo[7].datos.Add(new Node.info(Grafo[2], 23));
        Grafo[7].datos.Add(new Node.info(Grafo[8], 8));
        Grafo[7].datos.Add(new Node.info(Grafo[10], 12));
        Grafo[7].datos.Add(new Node.info(Grafo[12], 24));
            //9
        Grafo[8].datos.Add(new Node.info(Grafo[2], 27));
        Grafo[8].datos.Add(new Node.info(Grafo[5], 18));
        Grafo[8].datos.Add(new Node.info(Grafo[7], 8));
        Grafo[8].datos.Add(new Node.info(Grafo[9], 28));
        Grafo[8].datos.Add(new Node.info(Grafo[11], 13));
            //10
        Grafo[9].datos.Add(new Node.info(Grafo[5], 27));
        Grafo[9].datos.Add(new Node.info(Grafo[6], 8));
        Grafo[9].datos.Add(new Node.info(Grafo[8], 28));
        Grafo[9].datos.Add(new Node.info(Grafo[11], 13));
        Grafo[9].datos.Add(new Node.info(Grafo[17], 16));
        Grafo[9].datos.Add(new Node.info(Grafo[20], 15));
        Grafo[9].datos.Add(new Node.info(Grafo[21], 16));
        Grafo[9].datos.Add(new Node.info(Grafo[22], 21));
            //11
        Grafo[10].datos.Add(new Node.info(Grafo[0], 9));
        Grafo[10].datos.Add(new Node.info(Grafo[7], 12));
        Grafo[10].datos.Add(new Node.info(Grafo[12], 9));
        Grafo[10].datos.Add(new Node.info(Grafo[13], 17));
        Grafo[10].datos.Add(new Node.info(Grafo[15], 18));
            //12
        Grafo[11].datos.Add(new Node.info(Grafo[8], 21));
        Grafo[11].datos.Add(new Node.info(Grafo[9], 13));
        Grafo[11].datos.Add(new Node.info(Grafo[12], 0));
        Grafo[11].datos.Add(new Node.info(Grafo[17], 16));
            //13
        Grafo[12].datos.Add(new Node.info(Grafo[7], 24));
        Grafo[12].datos.Add(new Node.info(Grafo[10], 9));
        Grafo[12].datos.Add(new Node.info(Grafo[11], 0));
        Grafo[12].datos.Add(new Node.info(Grafo[15], 18));
        Grafo[12].datos.Add(new Node.info(Grafo[16], 14));
            //14
        Grafo[13].datos.Add(new Node.info(Grafo[10], 17));
        Grafo[13].datos.Add(new Node.info(Grafo[14], 6));
        Grafo[13].datos.Add(new Node.info(Grafo[15], 6));
            //15
        Grafo[14].datos.Add(new Node.info(Grafo[13], 6));
        Grafo[14].datos.Add(new Node.info(Grafo[15], 5));
        Grafo[14].datos.Add(new Node.info(Grafo[18], 12));
        Grafo[14].datos.Add(new Node.info(Grafo[33], 15));
            //16
        Grafo[15].datos.Add(new Node.info(Grafo[10], 18));
        Grafo[15].datos.Add(new Node.info(Grafo[12], 18));
        Grafo[15].datos.Add(new Node.info(Grafo[13], 6));
        Grafo[15].datos.Add(new Node.info(Grafo[14], 5));
        Grafo[15].datos.Add(new Node.info(Grafo[16], 8));
        Grafo[15].datos.Add(new Node.info(Grafo[18], 8));
            //17
        Grafo[16].datos.Add(new Node.info(Grafo[12], 14));
        Grafo[16].datos.Add(new Node.info(Grafo[15], 8));
        Grafo[16].datos.Add(new Node.info(Grafo[17], 5));
        Grafo[16].datos.Add(new Node.info(Grafo[18], 13));
            //18
        Grafo[17].datos.Add(new Node.info(Grafo[9], 16));
        Grafo[17].datos.Add(new Node.info(Grafo[11], 16));
        Grafo[17].datos.Add(new Node.info(Grafo[16], 5));
        Grafo[17].datos.Add(new Node.info(Grafo[18], 8));
        Grafo[17].datos.Add(new Node.info(Grafo[19], 6));
        Grafo[17].datos.Add(new Node.info(Grafo[20], 8));
        Grafo[17].datos.Add(new Node.info(Grafo[23], 12));
            //19
        Grafo[18].datos.Add(new Node.info(Grafo[14], 12));
        Grafo[18].datos.Add(new Node.info(Grafo[15], 8));
        Grafo[18].datos.Add(new Node.info(Grafo[16], 13));
        Grafo[18].datos.Add(new Node.info(Grafo[17], 8));
        Grafo[18].datos.Add(new Node.info(Grafo[19], 10));
        Grafo[18].datos.Add(new Node.info(Grafo[32], 7));
        Grafo[18].datos.Add(new Node.info(Grafo[33], 7));
            //20
        Grafo[19].datos.Add(new Node.info(Grafo[17], 6));
        Grafo[19].datos.Add(new Node.info(Grafo[18], 10));
        Grafo[19].datos.Add(new Node.info(Grafo[23], 7));
        Grafo[19].datos.Add(new Node.info(Grafo[29], 12));
        Grafo[19].datos.Add(new Node.info(Grafo[32], 12));
            //21
        Grafo[20].datos.Add(new Node.info(Grafo[9], 15));
        Grafo[20].datos.Add(new Node.info(Grafo[17], 8));
        Grafo[20].datos.Add(new Node.info(Grafo[21], 3));
        Grafo[20].datos.Add(new Node.info(Grafo[23], 14));
            //22
        Grafo[21].datos.Add(new Node.info(Grafo[9], 16));
        Grafo[21].datos.Add(new Node.info(Grafo[20], 3));
        Grafo[21].datos.Add(new Node.info(Grafo[22], 5));
        Grafo[21].datos.Add(new Node.info(Grafo[23], 12));
        Grafo[21].datos.Add(new Node.info(Grafo[24], 12));
            //23
        Grafo[22].datos.Add(new Node.info(Grafo[9], 21));
        Grafo[22].datos.Add(new Node.info(Grafo[21], 5));
        Grafo[22].datos.Add(new Node.info(Grafo[24], 8));
            //24
        Grafo[23].datos.Add(new Node.info(Grafo[17], 12));
        Grafo[23].datos.Add(new Node.info(Grafo[19], 7));
        Grafo[23].datos.Add(new Node.info(Grafo[20], 14));
        Grafo[23].datos.Add(new Node.info(Grafo[21], 12));
        Grafo[23].datos.Add(new Node.info(Grafo[24], 7));
        Grafo[23].datos.Add(new Node.info(Grafo[41], 6));
            //25
        Grafo[24].datos.Add(new Node.info(Grafo[21], 12));
        Grafo[24].datos.Add(new Node.info(Grafo[22], 8));
        Grafo[24].datos.Add(new Node.info(Grafo[23], 7));
        Grafo[24].datos.Add(new Node.info(Grafo[27], 16));
        Grafo[24].datos.Add(new Node.info(Grafo[41], 11));
            //26
        Grafo[25].datos.Add(new Node.info(Grafo[26], 4));
            //27
        Grafo[26].datos.Add(new Node.info(Grafo[25], 4));
        Grafo[26].datos.Add(new Node.info(Grafo[27], 4));
            //28
        Grafo[27].datos.Add(new Node.info(Grafo[24], 16));
        Grafo[27].datos.Add(new Node.info(Grafo[26], 4));
        Grafo[27].datos.Add(new Node.info(Grafo[28], 0));
        Grafo[27].datos.Add(new Node.info(Grafo[41], 9));
            //29
        Grafo[28].datos.Add(new Node.info(Grafo[27], 0));
        Grafo[28].datos.Add(new Node.info(Grafo[29], 7));
        Grafo[28].datos.Add(new Node.info(Grafo[40], 7));
            //30
        Grafo[29].datos.Add(new Node.info(Grafo[19], 12));
        Grafo[29].datos.Add(new Node.info(Grafo[28], 7));
        Grafo[29].datos.Add(new Node.info(Grafo[30], 5));
        Grafo[29].datos.Add(new Node.info(Grafo[40], 7));
        Grafo[29].datos.Add(new Node.info(Grafo[41], 3));
            //31
        Grafo[30].datos.Add(new Node.info(Grafo[29], 5));
        Grafo[30].datos.Add(new Node.info(Grafo[32], 6));
            //32
        Grafo[31].datos.Add(new Node.info(Grafo[35], 6));
        Grafo[31].datos.Add(new Node.info(Grafo[36], 5));
        Grafo[31].datos.Add(new Node.info(Grafo[37], 3));
            //33
        Grafo[32].datos.Add(new Node.info(Grafo[18], 7));
        Grafo[32].datos.Add(new Node.info(Grafo[19], 12));
        Grafo[32].datos.Add(new Node.info(Grafo[30], 6));
        Grafo[32].datos.Add(new Node.info(Grafo[33], 4));
        Grafo[32].datos.Add(new Node.info(Grafo[35], 7));
        Grafo[32].datos.Add(new Node.info(Grafo[40], 15));
            //34
        Grafo[33].datos.Add(new Node.info(Grafo[14], 15));
        Grafo[33].datos.Add(new Node.info(Grafo[18], 7));
        Grafo[33].datos.Add(new Node.info(Grafo[32], 4));
        Grafo[33].datos.Add(new Node.info(Grafo[34], 7));
        Grafo[33].datos.Add(new Node.info(Grafo[35], 6));
            //35
        Grafo[34].datos.Add(new Node.info(Grafo[33], 7));
        Grafo[34].datos.Add(new Node.info(Grafo[35], 7));
        Grafo[34].datos.Add(new Node.info(Grafo[38], 8));
            //36
        Grafo[35].datos.Add(new Node.info(Grafo[31], 6));
        Grafo[35].datos.Add(new Node.info(Grafo[32], 7));
        Grafo[35].datos.Add(new Node.info(Grafo[33], 6));
        Grafo[35].datos.Add(new Node.info(Grafo[34], 7));
        Grafo[35].datos.Add(new Node.info(Grafo[40], 7));
            //37
        Grafo[36].datos.Add(new Node.info(Grafo[31], 5));
        Grafo[36].datos.Add(new Node.info(Grafo[40], 3));
            //38
        Grafo[37].datos.Add(new Node.info(Grafo[31], 3));
        Grafo[37].datos.Add(new Node.info(Grafo[38], 0));
            //39
        Grafo[38].datos.Add(new Node.info(Grafo[34], 8));
        Grafo[38].datos.Add(new Node.info(Grafo[37], 0));
        Grafo[38].datos.Add(new Node.info(Grafo[39], 3));
            //40
        Grafo[39].datos.Add(new Node.info(Grafo[38], 3));
            //41
        Grafo[40].datos.Add(new Node.info(Grafo[28], 7));
        Grafo[40].datos.Add(new Node.info(Grafo[29], 7));
        Grafo[40].datos.Add(new Node.info(Grafo[32], 15));
        Grafo[40].datos.Add(new Node.info(Grafo[35], 7));
        Grafo[40].datos.Add(new Node.info(Grafo[36], 3));
            //42
        Grafo[41].datos.Add(new Node.info(Grafo[23], 6));
        Grafo[41].datos.Add(new Node.info(Grafo[24], 11));
        Grafo[41].datos.Add(new Node.info(Grafo[27], 9));
        Grafo[41].datos.Add(new Node.info(Grafo[29], 3));

         //Asignacion del nodo raiz
        Node temp = Grafo[inicio];
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

        //Meta
        temp = Grafo[objetivo];

         while(temp.Padre != null)
        {
            Debug.Log(temp.nombre);
            temp = temp.Padre;
        }
        Debug.Log(temp.nombre);
    }
}
