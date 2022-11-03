using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hardmodemanager : MonoBehaviour
{
    public GameObject CheckHard;
    public bool Hard;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CheckHard.activeSelf == true)
            Hard = true;
        else
            Hard = false;
    }
}
