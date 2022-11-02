using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccuracyManager : MonoBehaviour
{
    private int accuracy = 0;
    private int notenum = 0;

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
