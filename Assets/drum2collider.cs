using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drum2collider : MonoBehaviour
{
    AudioSource myAudio;
    TimingManager2 theTimingManager;
    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        theTimingManager = FindObjectOfType<TimingManager2>();


    }



    private void OnCollisionEnter(Collision collision)
    {

        myAudio.Play();
        theTimingManager.CheckTiming();


    }
}
