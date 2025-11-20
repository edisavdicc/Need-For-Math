using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameOverScreen : MonoBehaviour
{
    public GameObject EndScreen;
   public Text scoreText;
    public GameObject mathPanel;
    public GameObject gamePanels;
    public GameObject ScorePanel;
    public Transform endScreen;
    public Timer TimerScript;
    public TMP_Text TimerText;
    public GameObject leaderBoard;
    public GameObject scrollview;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            TimerScript.playing = false;
            EndScreen.gameObject.SetActive(true);
            mathPanel.gameObject.SetActive(false);
            gamePanels.gameObject.SetActive(false);
            
            scoreText.transform.SetParent(endScreen);
            scoreText.transform.position = new Vector3(1400, 600, 0);
            scoreText.color = Color.white;
            
            TimerText.transform.SetParent(endScreen);
            TimerText.transform.position = new Vector3(1250, 450, 0);
            TimerText.color = Color.white;
        }
            
        
    }

    public void lastScreen()
    {
        leaderBoard.gameObject.SetActive(false);
        EndScreen.gameObject.SetActive(true);

    }
    public void leaderboard()
    {
        leaderBoard.gameObject.SetActive(true);
        scrollview.gameObject.SetActive(true);
        EndScreen.gameObject.SetActive(false);
    }
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        scoreText.text = score.ToString();
    }
}
