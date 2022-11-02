using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager4 : MonoBehaviour
{
    public int bpm = 0;
    double currentTime = 0d;
    double totalTime = 0d;
    [SerializeField] Transform tfNoteAppear = null;
    [SerializeField] GameObject goNote = null;

    TimingManager4 theTimingManager;

    private ComboManager comboManager = null;

    void Start()
    {
        theTimingManager = GetComponent<TimingManager4>();

        GameObject cmObject = GameObject.Find("ComboManager");
        comboManager = cmObject.GetComponent<ComboManager>();
    }
    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;


        if (currentTime >= 900d / bpm)
        {
            GameObject t_Note = Instantiate(goNote, tfNoteAppear.position, Quaternion.identity);
            t_Note.transform.SetParent(this.transform);
            theTimingManager.boxNoteList.Add(t_Note);
            currentTime -= 900d / bpm;
        }


    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Note"))
        {
            theTimingManager.boxNoteList.Remove(collision.gameObject);
            Destroy(collision.gameObject);
            comboManager.ComboMiss();
            Debug.Log("Miss");
        }
    }

}
