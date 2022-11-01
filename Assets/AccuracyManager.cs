using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccuracyManager : MonoBehaviour
{
    public static int accuracy = 0;
    public static int notenum = 0;

    public void NotePlus()
    {
        notenum += 1;
    }

    public void PerfectAccuracy()
    {
        accuracy += 100;
    }

    public void GreatAccuracy()
    {
        accuracy += 75;
    }

    public void GoodAccuracy()
    {
        accuracy += 50;
    }

    public void BadAccuracy()
    {
        accuracy += 25;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
