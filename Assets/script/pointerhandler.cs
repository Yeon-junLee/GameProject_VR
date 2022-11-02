using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.Extras;
using UnityEngine.SceneManagement;
public class pointerhandler : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;

    public GameObject OptionMenu;
    public GameObject ExitMenu;
    public GameObject MainMenu;

    // Start is called before the first frame update
    void Start()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;
    }

    public void PointerInside(object sender, PointerEventArgs eventArgs)
    {
        if (eventArgs.target.CompareTag("UI"))
        {
            Debug.Log("UI Inside");
        }

    }

    public void PointerOutside(object sender, PointerEventArgs eventArgs)
    {
        if (eventArgs.target.CompareTag("UI"))
        {
            Debug.Log("UI Outside");
        }
    }

    public void PointerClick(object sender, PointerEventArgs eventArgs)
    {
        if (eventArgs.target.CompareTag("UI"))
        {
            Debug.Log("UI Clicked");
        }

        if (eventArgs.target.CompareTag("EXIT"))
        {
            Debug.Log("EXIT Clicked");
            ExitMenu_btn_clicked();
        }

        if (eventArgs.target.CompareTag("EXIT_BACK"))
        {
            Debug.Log("Exit back clicked");
            ExitMenu_btn_back_clicked();
        }

        if (eventArgs.target.CompareTag("OPTION"))
        {
            Debug.Log("Option Clicked");
            OptionMenu_btn_clicked();
        }

        if (eventArgs.target.CompareTag("OPTION_BACK"))
        {
            Debug.Log("Option back Clicked");
            OptionMenu_btn_back_clicked();
        }

        if (eventArgs.target.CompareTag("START"))
        {
            Debug.Log("Start Clicked");
            SceneManager.LoadScene("basic scene");
        }

        if (eventArgs.target.CompareTag("RESULT_BACK"))
        {
            SceneManager.LoadScene("UI scene");
        }
    }

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
}
