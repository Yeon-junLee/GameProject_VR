using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drum1collision : MonoBehaviour
{
    AudioSource myAudio;
    TimingManager theTimingManager;
    // Start is called before the first frame update
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        theTimingManager = FindObjectOfType<TimingManager>();


    }

   

    private void OnCollisionEnter(Collision collision)
    {
        
        myAudio.Play();
        theTimingManager.CheckTiming();
       
    
    }
}
