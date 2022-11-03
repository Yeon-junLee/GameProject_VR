using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private double timer = 0d;

    public GameObject SM;
    public GameObject CM;
    public GameObject AM;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > 68d)
        {
            SceneManager.LoadScene("result scene");
            DontDestroyOnLoad(SM);
            DontDestroyOnLoad(CM);
            DontDestroyOnLoad(AM);
        }
    }
}
