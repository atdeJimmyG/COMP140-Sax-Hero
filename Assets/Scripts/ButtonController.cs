using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{

    private SpriteRenderer spriteRenderer;
    public Sprite defultImage;
    public Sprite pressedImage;

    public KeyCode KeyToPress;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyToPress)) {
            spriteRenderer.sprite = pressedImage;
        }

        if (Input.GetKeyUp(KeyToPress)) {
            spriteRenderer.sprite = defultImage;
        }
    }
}
