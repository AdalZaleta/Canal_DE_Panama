using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    public struct info
    {
        public info(Node _nodo, int _distancia) {
            nodo = _nodo;
            distancia = _distancia;
        }

        public Node nodo;
        public int distancia;
    }

    public Node Padre;
    public List <Node> conexiones = new List<Node>();
    public List <info> datos = new List<info>();
    public int peso;
    public string nombre;
    public bool Visitado = false;

    /// Es una funcion para agregar una nueva coneccion al nodo
    static public Node addConection(string _nombre)
    {
        Node temp = new Node();
            temp.nombre= _nombre;
            temp.Padre = null;
        return temp;
    }
}
