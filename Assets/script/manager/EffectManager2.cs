using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager2 : MonoBehaviour
{
    [SerializeField] Animator noteDestroyAnimator = null;
    string hit = "Hit";

    public void NoteDestroyEffect()
    {
        noteDestroyAnimator.SetTrigger(hit);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
