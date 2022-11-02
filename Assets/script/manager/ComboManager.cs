using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ComboManager : MonoBehaviour
{
    private int combo = 0;
    public TextMeshProUGUI textCombo = null;

    public void ComboPlus()
    {
        combo += 1;
        textCombo.text = combo.ToString() + "Combo!";
    }

    public void ComboMiss()
    {
        combo = 0;
        textCombo.text = null;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
