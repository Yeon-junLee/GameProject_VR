using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.Extras;
using UnityEngine.SceneManagement;
public class pointerhandler : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;
    private onClick_UI onclick = null;

    // Start is called before the first frame update
    void Start()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;

        onClick_UI onclick = GetComponent<onClick_UI>();
    }

    public void PointerInside(object sender, PointerEventArgs eventArgs)
    {
        Debug.Log("UI Inside");
    }

    public void PointerOutside(object sender, PointerEventArgs eventArgs)
    {
        Debug.Log("UI Outside");
    }

    public void PointerClick(object sender, PointerEventArgs eventArgs)
    {
        if (eventArgs.target.CompareTag("EXIT"))
        {
            onclick.ExitMenu_btn_clicked();
        }

        if (eventArgs.target.CompareTag("EXIT_BACK"))
        {
            onclick.ExitMenu_btn_back_clicked();
        }

        if (eventArgs.target.CompareTag("OPTION"))
        {
            onclick.OptionMenu_btn_clicked();
        }

        if (eventArgs.target.CompareTag("OPTION_BACK"))
        {
            onclick.OptionMenu_btn_back_clicked();
        }

        if (eventArgs.target.CompareTag("START"))
        {
            SceneManager.LoadScene("basic scene");
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
