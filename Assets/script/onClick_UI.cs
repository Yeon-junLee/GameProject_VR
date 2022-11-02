using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClick_UI : MonoBehaviour
{
    public GameObject OptionMenu;
    public GameObject ExitMenu;
    public GameObject MainMenu;

    public void ExitMenu_btn_clicked()
    {
        MainMenu.SetActive(false);
        ExitMenu.SetActive(true);
    }

    public void ExitMenu_btn_back_clicked()
    {
        ExitMenu.SetActive(false);
        MainMenu.SetActive(true);
    }

    public void OptionMenu_btn_clicked()
    {
        MainMenu.SetActive(false);
        OptionMenu.SetActive(true);
    }

    public void OptionMenu_btn_back_clicked()
    {
        OptionMenu.SetActive(false);
        MainMenu.SetActive(true);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
