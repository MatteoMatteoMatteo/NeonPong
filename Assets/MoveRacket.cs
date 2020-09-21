
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRacket : MonoBehaviour
{
    public float speed = 30;
    public string axis = "Vertical";

    void OnCollisionEnter2D(Collision2D col)
    {





        if (col.gameObject.CompareTag("Kick")) FindObjectOfType<audioManager>().Play("Kick");
        if (col.gameObject.CompareTag("Clap")) FindObjectOfType<audioManager>().Play("Clap");
        if (col.gameObject.CompareTag("Bass")) FindObjectOfType<audioManager>().Play("Bass");
        if (col.gameObject.CompareTag("Chord")) FindObjectOfType<audioManager>().Play("Chord");



    }
}
