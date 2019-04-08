using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat_Script : MonoBehaviour
{
    public float hitDistance;
    public float speedMove;
    private Rigidbody cc;
    public enum state {
        Waiting,
        Wander
    } 

    public state actualState = state.Waiting;
    public bool isHiting;

    void Start() 
    {
        cc = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit; 
        isHiting = Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), out hit, 1.0f);
        if(isHiting)
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * hitDistance, Color.red);
            cc.velocity = Vector3.zero;
            actualState = state.Waiting;
        }
        else
        {
            actualState = state.Wander;
            cc.velocity = transform.TransformDirection(Vector3.right) * speedMove;
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.right) * hitDistance, Color.green);
        }
    }
}
