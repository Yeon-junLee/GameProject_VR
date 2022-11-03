using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingManager2 : MonoBehaviour
{
    
    public List<GameObject> boxNoteList = new List<GameObject>();

    [SerializeField] Transform Center = null;
    [SerializeField] RectTransform[] timingRect = null;
    Vector2[] timingBoxes = null;

    private ScoreManager scoreManager = null;
    private ComboManager comboManager = null;
    private AccuracyManager accuracyManager = null;

    EffectManager2 Effect;

    void Start()
    {
        timingBoxes = new Vector2[timingRect.Length];
        for (int i = 0; i < timingRect.Length; i++)
        {
            timingBoxes[i].Set(Center.position.y - timingRect[i].rect.height / 2,
                               Center.position.y + timingRect[i].rect.height / 2);
        }

        GameObject smObject = GameObject.Find("ScoreManager");
        scoreManager = smObject.GetComponent<ScoreManager>();

        GameObject cmObject = GameObject.Find("ComboManager");
        comboManager = cmObject.GetComponent<ComboManager>();

        GameObject amObject = GameObject.Find("AccuracyManager");
        accuracyManager = amObject.GetComponent<AccuracyManager>();

        Effect = FindObjectOfType<EffectManager2>();
    }

    // Update is called once per frame
    public void CheckTiming()
    {
        for (int i = 0; i < boxNoteList.Count; i++)
        {
            float t_notePosY = boxNoteList[i].transform.localPosition.y;
            for (int x = 0; x < timingBoxes.Length; x++)
            {
                if (timingBoxes[x].x <= t_notePosY && t_notePosY <= timingBoxes[x].y)
                {
                    boxNoteList[i].GetComponent<Note>().HideNote();
                    if (x < timingBoxes.Length - 1)
                    {
                        Effect.NoteDestroyEffect();
                    }
                    boxNoteList.RemoveAt(i);
                    Debug.Log("Hit" + x);

                    if (x == 0)
                    {
                        scoreManager.PerfectHit();
                        comboManager.ComboPlus();
                    }
                    else if (x == 1)
                    {
                        scoreManager.GreatHit();
                        comboManager.ComboPlus();
                    }
                    else if (x == 2)
                    {
                        scoreManager.CoolHit();
                        comboManager.ComboPlus();
                    }
                    else if (x == 3)
                    {
                        scoreManager.BadHit();
                        comboManager.ComboPlus();
                    }

                    return;
                }
            }
        }

        Debug.Log("Miss");
    }
}
