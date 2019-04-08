using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel_Script : MonoBehaviour
{
    public Vector3 DebugVector;
    public GameObject water;
    public GameObject leftDoor;
    public GameObject rightDoor;
    public enum state {
        Filling,
        Emptying,
        Fill,
        Empty
    }

    public state actualEstate = state.Empty;
    public Transform topWater;
    public Transform bottomWater;

    private void Update() {
        if(actualEstate == state.Filling)
        {
            DebugVector = new Vector3(water.transform.position.x, topWater.position.y, water.transform.position.z);
            water.transform.position = Vector3.MoveTowards(water.transform.position, DebugVector, Time.deltaTime);
            if(Mathf.Abs(water.transform.position.y) - topWater.position.y == 0.0f)
            {
                actualEstate = state.Fill;
            }
        }
        if(actualEstate == state.Emptying)
        {
            water.transform.position = Vector3.MoveTowards(water.transform.position, new Vector3(water.transform.position.x, bottomWater.position.y, water.transform.position.z), Time.deltaTime);
            if(Mathf.Abs(water.transform.position.y) - topWater.position.y == 0.0f)
            {
                actualEstate = state.Empty;
            }
        }   
    }
}
