﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteScroller : MonoBehaviour
{

    public float beatTempo;

    public bool hasStarted;


    void Start()
    {
        beatTempo = beatTempo / 60f;
    }

    void FixedUpdate()
    {
        if (!hasStarted) {
           /* if (Input.anyKeyDown) {
                hasStarted = true;
            }*/

        }
        else {
            transform.position -= new Vector3(beatTempo * Time.fixedDeltaTime, 0f, 0f);
        }
    }
}

