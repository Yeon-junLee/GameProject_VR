using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{

    public int score = 0;
    // Start is called before the first frame update

    public void PerfectHit()
    {
        score += 1000;
    }

    public void GreatHit()
    {
        score += 750;
    }

    public void GoodHit()
    {
        score += 500;
    }

    public void BadHit()
    {
        score += 250;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
