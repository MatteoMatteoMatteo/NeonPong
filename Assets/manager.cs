using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI winner;
    public float period = 0.1f;
    public GameObject kick;
    private GameObject _kickBall;
    public GameObject clap;
    private GameObject _clapBall;
    public GameObject bass;
    private GameObject _bassBall;
    public GameObject chord;
    private GameObject _chordBall;

    public lose player1;
    public loose player2;

    public GameObject ball;

    public int timer;


    void Start()
    {
        // InvokeRepeating("Countdown", 0.0f, 1.0f);
        // FindObjectOfType<audioManager>().Play("Theme");
        Cursor.visible = false;
    }

    /*void Countdown()
    {
        timer--;
        timerText.text = "" + timer;

        if (timer == 0)
        {
            CancelInvoke();
            winscreen.SetActive(true);
            if (player1.score > player2.score)
            {
                winner.text = "PLayer Left won!";
            }
            else if (player1.score < player2.score)
            {
                winner.text = "Player Right won!";
            }
            else
            {
                winner.text = "It's a draw!";
            }

            Destroy(ball);
            FindObjectOfType<audioManager>().Play("Won");
            StartCoroutine(ExecuteAfterTime(4));
        }
    }*/

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + -1);
        }
        
        //Kick
        if (Input.GetKeyDown(KeyCode.W))
        {
             _kickBall=Instantiate(kick, new Vector3(56,0,0), Quaternion.identity);
        }else if (Input.GetKeyUp(KeyCode.W))
        {
            Destroy(_kickBall);
        }
        //Clap
        if (Input.GetKeyDown(KeyCode.A))
        {
            _clapBall=Instantiate(clap, new Vector3(56,20,0), Quaternion.identity);
        }else if (Input.GetKeyUp(KeyCode.A))
        {
            Destroy(_clapBall);
        }
        //bass
        if (Input.GetKeyDown(KeyCode.D))
        {
            _bassBall=Instantiate(bass, new Vector3(56,-10,0), Quaternion.identity);
        }else if (Input.GetKeyUp(KeyCode.D))
        {
            Destroy(_bassBall);
        }
        //chord
        if (Input.GetKeyDown(KeyCode.S))
        {
            _chordBall=Instantiate(chord, new Vector3(56,-30,0), Quaternion.identity);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            Destroy(_chordBall);
        }
    }

    /*IEnumerator ExecuteAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + -1);
    }*/
}