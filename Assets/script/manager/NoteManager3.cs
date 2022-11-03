using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager3 : MonoBehaviour
{
    public int bpm = 0;
    double currentTime = 0d;
    double totalTime = 0d;
    [SerializeField] Transform tfNoteAppear = null;
    [SerializeField] GameObject goNote = null;

    TimingManager3 theTimingManager;

    private ComboManager comboManager = null;
    private AccuracyManager accuracyManager = null;
    EffectManager3 Effect;
    void Start()
    {
        theTimingManager = GetComponent<TimingManager3>();

        GameObject cmObject = GameObject.Find("ComboManager");
        comboManager = cmObject.GetComponent<ComboManager>();

        GameObject amObject = GameObject.Find("AccuracyManager");
        accuracyManager = amObject.GetComponent<AccuracyManager>();
        Effect = FindObjectOfType<EffectManager3>();
    }

    void Update()
    {
        currentTime += Time.deltaTime;


        if (currentTime >= 1960d / bpm)
        {
            GameObject t_Note = Instantiate(goNote, tfNoteAppear.position, Quaternion.identity);
            
            t_Note.transform.SetParent(this.transform);

            theTimingManager.boxNoteList.Add(t_Note);
            currentTime -= 1960d / bpm;
            accuracyManager.NotePlus();
        }


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Note"))
        {
            theTimingManager.boxNoteList.Remove(collision.gameObject);
            Destroy(collision.gameObject);
            comboManager.ComboMiss();
            accuracyManager.MissAccuracy();
            Effect.JudgementEffect(4);
            Debug.Log("Miss");

        }
    }

}
