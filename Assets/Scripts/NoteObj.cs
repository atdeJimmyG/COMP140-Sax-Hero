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

