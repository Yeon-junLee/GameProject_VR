using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectManager1 : MonoBehaviour
{
    [SerializeField] Animator noteDestroyAnimator = null;
    string hit = "Hit";

    public void NoteDestroyEffect()
    {
        noteDestroyAnimator.SetTrigger(hit);
    }

}
