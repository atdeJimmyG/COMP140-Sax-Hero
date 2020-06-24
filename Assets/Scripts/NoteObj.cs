using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObj : MonoBehaviour {

    public bool canBePressed;

    public KeyCode KeyToPress;
    

    void Update() {
        if (Input.GetKeyDown(KeyToPress)) {
            if (canBePressed) {
                gameObject.SetActive(false);

                GameManager.instance.NoteHit();
            }
        }

        // Place note using space
        /*if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(Empty, transform.position, transform.rotation);
        }*/
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "Activator") {
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) {
        if (other.tag == "Activator") {
            canBePressed = false;

            GameManager.instance.NoteMiss();
        }
    }
}

