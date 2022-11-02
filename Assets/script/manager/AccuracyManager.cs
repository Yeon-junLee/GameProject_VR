using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AccuracyManager : MonoBehaviour
{
    private int accuracy = 0;
    private int notenum = 0;
    public TextMeshProUGUI textAccuracy = null;

    public void NotePlus()
    {
        notenum += 1;
    }

    public void PerfectAccuracy()
    {
        accuracy += 100;
        textAccuracy.text = "Accuracy: " + (accuracy/notenum).ToString() +"%";
    }

    public void GreatAccuracy()
    {
        accuracy += 75;
        textAccuracy.text = "Accuracy: " + (accuracy / notenum).ToString() + "%";
    }

    public void CoolAccuracy()
    {
        accuracy += 50;
        textAccuracy.text = "Accuracy: " + (accuracy / notenum).ToString() + "%";
    }

    public void BadAccuracy()
    {
        accuracy += 25;
        textAccuracy.text = "Accuracy: " + (accuracy / notenum).ToString() + "%";
    }

    public void MissAccuracy()
    {
        textAccuracy.text = "Accuracy: " + (accuracy / notenum).ToString() + "%";
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
