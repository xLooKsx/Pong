using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CpuMovement : MonoBehaviour
{
    public float movementSpeed;
    private Transform ballPosition;
    private Rigidbody2D myRigidbody2D;
    void Start()
    {
        myRigidbody2D = this.GetComponent<Rigidbody2D>();
        FindBall();
    }

    void FixedUpdate()
    {

        if (ballPosition == null) {
            FindBall();
        }

        Vector2 ballPositionOnY = new Vector2(0, ballPosition.position.y);
        Vector2 newPosition = Vector2.MoveTowards(myRigidbody2D.position, ballPositionOnY, movementSpeed * Time.fixedDeltaTime);
        myRigidbody2D.MovePosition(newPosition);
    }

    void FindBall()
    {
        GameObject ball = GameObject.FindWithTag("Ball");
        if (ball != null)
        {
            ballPosition = ball.transform;
        }
    }
}
