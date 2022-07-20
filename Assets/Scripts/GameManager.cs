using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI timeText;

    [SerializeField]
    private TextMeshProUGUI deathText;
    
    [SerializeField]
    private GameObject gameScene;
    [SerializeField]
    private GameObject endScene;

    [SerializeField]
    private TextMeshProUGUI endTimeText;
    [SerializeField]
    private TextMeshProUGUI endDeathText;


    private float timer =0;
    private string timerFormatted;

    private int totalDeaths = 0;
    private bool playerStarted = false;

    public static GameManager instance;

    

    private void Awake()
    {
        if (GameManager.instance)
        {
            Destroy(base.gameObject);
        }
        else
        {
            GameManager.instance = this;
        }
    }

    

    // Start is called before the first frame update
    void Start()
    {
        endScene.SetActive(false);
        playerStarted = false;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(playerStarted)
        {
            timer += Time.deltaTime;
            System.TimeSpan t = System.TimeSpan.FromSeconds(timer);
            timerFormatted = string.Format("{0:D2}:{1:D2}:{2:D2}", t.Minutes, t.Seconds, t.Milliseconds);
            timeText.text = timerFormatted;
        }
        else
        {
            if(Input.anyKeyDown)
            {
                playerStarted = true;
            }
        }
        
    }

    public void PlayerDead()
    {
        totalDeaths++;
        deathText.text = "Deaths: " + totalDeaths;
    }

    public void PlayerReachedFinish()
    {
        gameScene.SetActive(false);
        endScene.SetActive(true);
        endTimeText.text = "TOTAL TIME: " + timerFormatted;
        endDeathText.text = "NUMBER OF DEATHS: " + totalDeaths;



    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
