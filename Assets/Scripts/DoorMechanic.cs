using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMechanic : MonoBehaviour {
    public bool isOpen = false;
    public bool inReach = false;
    public GameObject Door;
    public GameObject InteractionText;

    void OnTriggerEnter(Collider collision) {
        if (collision.gameObject.tag == "Reach") {
            inReach = true;
            InteractionText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider collision) {
            inReach = false;
            InteractionText.SetActive(false);
    }

    void Update() {
        if (inReach == true && isOpen == false && Input.GetKeyDown(KeyCode.E)) {
                Door.GetComponent<Animator>().Play("Open");
                isOpen = true;
        }
        
        if (inReach == true && isOpen == true && Input.GetKeyDown(KeyCode.E)) {
                Door.GetComponent<Animator>().Play("Close");
                isOpen = false;
        }
    }
}
