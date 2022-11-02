using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drum4collision : MonoBehaviour
{
    AudioSource myAudio;
    TimingManager4 theTimingManager;
    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        theTimingManager = FindObjectOfType<TimingManager4>();


    }



    private void OnCollisionEnter(Collision collision)
    {

        myAudio.Play();
        theTimingManager.CheckTiming();


    }
}
