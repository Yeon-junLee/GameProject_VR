using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drum3collision : MonoBehaviour
{
    AudioSource myAudio;
    TimingManager3 theTimingManager;
    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        theTimingManager = FindObjectOfType<TimingManager3>();


    }



    private void OnCollisionEnter(Collision collision)
    {

        myAudio.Play();
        theTimingManager.CheckTiming();


    }
}
