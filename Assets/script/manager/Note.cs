using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    bool Hard, Invincible;
    GameObject HMM, IMM;

    // private double blockdestroytime = 0d;
    private float noteSpeed = 100;

    UnityEngine.UI.Image noteImage;

    void Start()
    {
        noteImage = GetComponent<UnityEngine.UI.Image>();

        //HMM = GameObject.Find("HardmodeManager");
        //IMM = GameObject.Find("InvincibleManager");

        //Hard = HMM.GetComponent<Hardmodemanager>().Hard;
        //Invincible = IMM.GetComponent<Invinciblemodemanager>().Invincible;

        //if (Hard)
        //    noteSpeed = 250;
    }

   
    // Update is called once per frame
    void Update()
    {
        transform.localPosition += Vector3.down * noteSpeed * Time.deltaTime;
        // blockdestroytime += Time.deltaTime;

        
    }

    public void HideNote()
    {
        noteImage.enabled = false;
    }
}
