using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableUI : MonoBehaviour
{
    private BoxCollider boxCollider;
    private RectTransform rectTransform;


    void Start()
    {
        rectTransform = GetComponent<RectTransform>();

        boxCollider = gameObject.AddComponent<BoxCollider>();

        boxCollider.size = rectTransform.sizeDelta;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
