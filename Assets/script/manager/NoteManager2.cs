using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteManager2 : MonoBehaviour
{
    public int bpm = 0;
    double currentTime = 0d;
    double totalTime = 0d;
    [SerializeField] Transform tfNoteAppear = null;
    [SerializeField] GameObject goNote = null;


    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;


        if (currentTime >= 5600d / bpm)
        {
            GameObject t_Note = Instantiate(goNote, tfNoteAppear.position, Quaternion.identity);
            t_Note.transform.SetParent(this.transform);
            currentTime -= 5600d / bpm;
        }



    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Note"))
        {
            Destroy(collision.gameObject);

        }
    }

}
