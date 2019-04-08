using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Script : MonoBehaviour
{

    public GameObject Compuerta;
    public GameObject leftDoor;
    public GameObject rightDoor;

    private void OnTriggerStay(Collider other) {
        if(other.CompareTag("Boat"))
        {
            if(Compuerta.GetComponent<Panel_Script>().actualEstate == Panel_Script.state.Empty)
            {
                if(other.GetComponent<Boat_Script>().actualState == Boat_Script.state.Waiting)
                {
                    if(leftDoor != null)
                    {
                        if(leftDoor.GetComponent<Gate_Scirpt>().actualState != Gate_Scirpt.state.GateClose)
                        {
                            leftDoor.GetComponent<Gate_Scirpt>().actualState = Gate_Scirpt.state.MoveToClose;
                        }
                        else if(leftDoor.GetComponent<Gate_Scirpt>().actualState == Gate_Scirpt.state.GateClose)
                        {
                            Compuerta.GetComponent<Panel_Script>().actualEstate = Panel_Script.state.Filling;
                        }
                    }
                }
            }
            if(Compuerta.GetComponent<Panel_Script>().actualEstate == Panel_Script.state.Fill)
            {
                if(other.GetComponent<Boat_Script>().actualState == Boat_Script.state.Waiting)
                {
                    if(rightDoor != null)
                    {
                        if(rightDoor.GetComponent<Gate_Scirpt>().actualState != Gate_Scirpt.state.GateOpen)
                        {
                            rightDoor.GetComponent<Gate_Scirpt>().actualState = Gate_Scirpt.state.MoveToOpen;
                        }
                    }
                }
            }
        }
    }
}
