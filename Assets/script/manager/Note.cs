using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public double blockdestroytime = 0d;
    public float noteSpeed = 800;

    UnityEngine.UI.Image noteImage;

    void Start()
    {
        noteImage = GetComponent<UnityEngine.UI.Image>();
    }

   
    // Update is called once per frame
    void Update()
    {
        transform.localPosition += Vector3.down * noteSpeed * Time.deltaTime;
        blockdestroytime += Time.deltaTime;
        if(blockdestroytime > 10d)
        {
            Destroy(this.gameObject);
            Debug.Log("Miss");
        }
    }

    public void HideNote()
    {
        noteImage.enabled = false;
    }
}
