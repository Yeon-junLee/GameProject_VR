using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{

    private int score = 0;
    public TextMeshProUGUI textScore = null;

    public void PerfectHit()
    {
        score += 1000;
        textScore.text = "Score: " + score.ToString();
    }

    public void GreatHit()
    {
        score += 750;
        textScore.text = "Score: " + score.ToString();
    }

    public void GoodHit()
    {
        score += 500;
        textScore.text = "Score: " + score.ToString();
    }

    public void BadHit()
    {
        score += 250;
        textScore.text = "Score: " + score.ToString();
    }

    void Start()
    {
        textScore.text = "Score : 0";
        textScore.text = "Score: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
