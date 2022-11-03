using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invinciblemodemanager : MonoBehaviour
{
    public GameObject CheckInvincible;
    public bool Invincible;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CheckInvincible.activeSelf == true)
            Invincible = true;
        else
            Invincible = false;
    }
}
