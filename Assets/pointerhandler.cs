using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR.Extras;

public class pointerhandler : MonoBehaviour
{
    public SteamVR_LaserPointer laserPointer;

    // Start is called before the first frame update
    void Start()
    {
        laserPointer.PointerIn += PointerInside;
        laserPointer.PointerOut += PointerOutside;
        laserPointer.PointerClick += PointerClick;
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
        if (eventArgs.target.CompareTag("UI"))
        {
            Debug.Log(eventArgs.target.name);       // 클릭 버튼 생각해서 함수 또 짜야됨 지금 기기 없이는 확인 못함
        }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
