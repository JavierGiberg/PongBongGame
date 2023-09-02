using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public BallMovement ballMovement;

    private int scorePlayerOne = 0;
    private int scorePlayerTwo = 0;
    //test new branch 1111
    public GameObject scoreTextPlayerOne;
    public GameObject scoreTextPlayerTwo;

    public int goalToWin;



    // Update is called once per frame
    void Update()
    {
        if (this.scorePlayerOne >= this.goalToWin || this.scorePlayerTwo >= this.goalToWin)
            Debug.Log("Game Won");
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
