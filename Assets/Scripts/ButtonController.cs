using UnityEngine;
using System.Collections;
using System.IO.Ports;
using System;


public class ButtonController : MonoBehaviour
{
    SerialPort sp = new SerialPort("COM4", 9600);
    private SpriteRenderer spriteRenderer;
    public Sprite defultImage;
    public Sprite pressedImage;

    private KeyCode KeyToPress;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        sp.Open();
    }

    void Update()
    {
        //Arduino button input code
        //Commented out as unable to test
        /*
        if (sp.IsOpen) {
            try {
                print(sp.ReadByte());
            }
            catch (Exception) {

                throw;
            }
        }

        
        if (sp.ReadByte() == 1) {
            KeyToPress = KeyCode.Alpha1;
        }
        if (sp.ReadByte() == 2) {
            KeyToPress = KeyCode.Alpha2;
        }
        if (sp.ReadByte() == 3) {
            KeyToPress = KeyCode.Alpha3;
        }
        if (sp.ReadByte() == 4) {
            KeyToPress = KeyCode.Alpha4;
        }
        */



        if (Input.GetKeyDown(KeyToPress)) {
            spriteRenderer.sprite = pressedImage;
        }

        if (Input.GetKeyUp(KeyToPress)) {
            spriteRenderer.sprite = defultImage;
        }


    }
}
