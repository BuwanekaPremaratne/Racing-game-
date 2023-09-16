using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 position;
    public Image car;

    private bool moveLeft = false;
    private bool moveRight = false;

    private bool iscalculating = false;

    public GameObject startBtn, endBtn;

    public int LeftBorder=-10;
    public int RightBorder=10;

    private bool isStart=false;

    [SerializeField] Text scoreTxt;
    [SerializeField] Text highScoreText;

    private float score = 0f;
    //private float highScore = 0f;

    TrackCntrl track;

    void Awake()
    {
        track = FindAnyObjectByType<TrackCntrl>();

    }

    void Start()
    {
        position = car.transform.position;
        highScoreText.text = "High Score: " + Mathf.Round(ScoreManager.HighScore).ToString();

    }

    void Update()
    {
        if(isStart)
        {
            if (moveLeft)
        {
        
            position.x = Mathf.Clamp(position.x - speed * Time.deltaTime, LeftBorder, RightBorder);
        }
        else if (moveRight)
        {
        
            position.x = Mathf.Clamp(position.x + speed * Time.deltaTime, LeftBorder, RightBorder);
        }

        if (iscalculating)
        {
            calculateScore();
        }
        
        car.transform.position = position;

        }
        
    }

    public void OnLeftButtonDown()
    {
        moveLeft = true;
    }

    public void OnLeftButtonUp()
    {
        moveLeft = false;
    }

    public void OnRightButtonDown()
    {
        moveRight = true;
    }

    public void OnRightButtonUp()
    {
        moveRight = false;
    }

    public void OnStart()
    {
        isStart=true;
        startBtn.SetActive(false);
        endBtn.SetActive(true);
        track.isScrowlling = true;
        iscalculating = true;

    }

    void calculateScore()
    {

        // Increment the score by Time.deltaTime every frame
        score += Time.deltaTime;

        // Update the score text UI
        scoreTxt.text = "Score: " + Mathf.Round(score).ToString();

        // Update the high score using the HighScoreManager
        ScoreManager.HighScore = score;


    }

    public void OnEnd()
    {
        SceneManager.LoadScene(0);
    }
}


