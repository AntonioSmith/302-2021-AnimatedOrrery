using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayStateMachine : MonoBehaviour
{
    public void Play()
    {
        Time.timeScale = 1;
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }
    public void Rewind()
    {
        //Time.timeScale = -1; // THAT'S ILLEGAL
    }
}
