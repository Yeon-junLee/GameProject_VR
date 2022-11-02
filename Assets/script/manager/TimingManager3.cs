using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingManager3 : MonoBehaviour
{
    
    public List<GameObject> boxNoteList = new List<GameObject>();

    [SerializeField] Transform Center = null;
    [SerializeField] RectTransform[] timingRect = null;
    Vector2[] timingBoxes = null;

    // Start is called before the first frame update
    void Start()
    {
        timingBoxes = new Vector2[timingRect.Length];
        for (int i = 0; i < timingRect.Length; i++)
        {
            timingBoxes[i].Set(Center.position.y - timingRect[i].rect.height / 2,
                               Center.position.y + timingRect[i].rect.height / 2);
        }
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
                    boxNoteList.RemoveAt(i);
                    Debug.Log("Hit" + x);
                    return;
                }
            }
        }

        Debug.Log("Miss");
    }
}
