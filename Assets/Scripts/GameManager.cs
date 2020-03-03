using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource music;

    public bool startPlaying;

    public NoteScroller theNS;

    public static GameManager instance;
    

    void Start()
    {
        instance = this;
    }


    void Update()
    {
        if (!startPlaying) {
            startPlaying = true;
            theNS.hasStarted = true;

            music.Play();
        }
    }

    public void NoteHit() {
        Debug.Log("Note Hit");
    }

    public void NoteMiss() {
        Debug.Log("Note Miss");
    }
}
