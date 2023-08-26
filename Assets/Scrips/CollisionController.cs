using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionController : MonoBehaviour
{
    public BallMovement ballMovement;
    public ScoreController scoreController;

    void BounceFromRacket(Collision2D c)
    {
        Vector3 ballPosition = this.transform.position;
        Vector3 racketPosition = c.gameObject.transform.position;

        float racketHight = c.collider.bounds.size.y;

        float x;
        if (c.gameObject.name == "RacketPlayerOne")
        {
            Debug.Log("if");
            x = 1;
        }
        else
        {
            Debug.Log("Else");
            x = -1;
        }

        float y = (ballPosition.y - racketPosition.y) / racketHight;

        this.ballMovement.IncHitCounter();
        this.ballMovement.MoveBall(new Vector2 (x, y));
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "RacketPlayerOne" || collision.gameObject.name == "RacketPlayerTwo")
        {
            this.BounceFromRacket(collision);
        }
        else
            if (collision.gameObject.name == "WallLeft")
        {
            Debug.Log("Coll W left");
            this.scoreController.GoalPlayerTwo();
            StartCoroutine(this.ballMovement.StarBall(true));
        }
        else
            if (collision.gameObject.name == "WallRight")
        {
            Debug.Log("Coll W right");
            this.scoreController.GoalPlayerOne();
            StartCoroutine(this.ballMovement.StarBall(false));
        }
    }
}
