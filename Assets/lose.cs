using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using EZCameraShake;

public class lose : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI pl2Text;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        score++;
        pl2Text.text = "" + score + "";
        FindObjectOfType<audioManager>().Play("WinPoint");
        // CameraShaker.Instance.ShakeOnce(1f, 1f, 0f, 1f);

    }
}
