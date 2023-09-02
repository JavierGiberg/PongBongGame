using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreController : MonoBehaviour
{
    public BallMovement ballMovement;

    public int scorePlayerOne = 0;
    public int scorePlayerTwo = 0;

    public GameObject scoreTextPlayerOne;
    public GameObject scoreTextPlayerTwo;

    public int goalToWin;

    void Update()
    {
        if (this.scorePlayerOne >= this.goalToWin || this.scorePlayerTwo >= this.goalToWin)
        {
            Debug.Log("Game Won");
            SceneManager.LoadScene("GameOver");
        }
    }
    private void FixedUpdate()
    {
        Text uiScorePlayerOne = this.scoreTextPlayerOne.GetComponent<Text>();
        uiScorePlayerOne.text = this.scorePlayerOne.ToString();

        Text uiScorePlayerTwo = this.scoreTextPlayerTwo.GetComponent<Text>();
        uiScorePlayerTwo.text = this.scorePlayerTwo.ToString();
    }

    public void GoalPlayerOne()
    {
        this.scorePlayerOne++;
    }
    public void GoalPlayerTwo()
    {
        this.scorePlayerTwo++;
    }
}
