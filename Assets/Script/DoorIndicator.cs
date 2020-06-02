using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorIndicator : MonoBehaviour
{
    public bool isClose = false;
    GameController controller;
    private void Start() {
        controller = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
    }
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "wall"){
            isClose = true;
            controller.CheckAllDoors();
        }
    }
    private void OnTriggerExit(Collider other) {
        if(other.tag == "wall"){
            isClose=false;
        }
    }
}
