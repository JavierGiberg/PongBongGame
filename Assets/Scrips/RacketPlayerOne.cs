using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPlayerOne : MonoBehaviour
{
    public ScoreController scoreController;
    public float movementSpeed;
    public float bigYScale = 2.0f;

    private void FixedUpdate()
    {
        float v = Input.GetAxisRaw("Vertical1");

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v) * movementSpeed;
        
        
        if (Input.GetKeyDown(KeyCode.Space) && this.scoreController.scorePlayerTwo >= 2)
        {
            Vector3 newScale = new Vector3(transform.localScale.x, bigYScale, transform.localScale.z);
            transform.localScale = newScale;
        }
    }

}
