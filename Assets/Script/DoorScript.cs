using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    bool disableMove = true;
    public Material materialsRed;
    public Material materialsYellow;
    private void Start() {
        GetComponent<MeshRenderer>().material = materialsYellow;
        GetComponent<Rigidbody>().isKinematic = true;
    }
    private void OnCollisionEnter(Collision other) {
        if(other.transform.tag == "ball"){
            disableMove = false;
            GetComponent<Rigidbody>().isKinematic = false;
            GetComponent<MeshRenderer>().material = materialsRed;
        }
    }
}
