using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameResult : MonoBehaviour
{
    public TextMeshProUGUI textScore = null;
    public TextMeshProUGUI textAccuracy= null;

    GameObject Score, Accuracy;

    int score;
    float accuracy;
    int notenum;

    // Start is called before the first frame update
    void Start()
    {
        Score = GameObject.Find("ScoreManager");
        score = Score.GetComponent<ScoreManager>().score;

        textScore.text = "Score : " + score.ToString();

        Accuracy = GameObject.Find("AccuracyManager");
        accuracy = Accuracy.GetComponent<AccuracyManager>().accuracy;
        notenum = Accuracy.GetComponent<AccuracyManager>().notenum;

        textAccuracy.text = "Accuracy : " + (accuracy/(float)notenum).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
