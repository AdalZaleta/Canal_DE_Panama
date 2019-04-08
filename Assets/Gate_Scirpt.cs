using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate_Scirpt : MonoBehaviour
{
    public enum state {
        GateOpen,
        GateClose,
        MoveToOpen,
        MoveToClose
    }

    public state actualState = state.GateClose;
    public Transform openDoor;
    public Transform closeDoor;
    // Update is called once per frame
    void Update()
    {
        if(actualState == state.MoveToOpen)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y, openDoor.position.z), Time.deltaTime);
            if(Mathf.Abs(transform.position.z) - openDoor.position.z == 0.0f)
            {
                actualState = state.GateOpen;
            }
        }
        if(actualState == state.MoveToClose)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(transform.position.x, transform.position.y, closeDoor.position.z), Time.deltaTime);
            if(Mathf.Abs(transform.position.z) - closeDoor.position.z == 0.0f)
            {
                actualState = state.GateClose;
            }
        }
    }
}
