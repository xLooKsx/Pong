using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInitialKick : MonoBehaviour
{
    public float movementSpeed;

    private Rigidbody2D myRigidbody2D;
    void Start()
    {
        myRigidbody2D = this.GetComponent<Rigidbody2D>();
        LaunchBall();
    }

    // Update is called once per frame
    void LaunchBall()
    {
        int xDirection = Random.Range(0, 2) == 0 ? -1 : 1;
        float yDirection = Random.Range(-1f, 1f);

        Vector2 direction = new Vector2(xDirection, yDirection).normalized;
        myRigidbody2D.velocity = direction * movementSpeed;
    }

    void FixedUpdate()
    {
        myRigidbody2D.velocity = myRigidbody2D.velocity.normalized * movementSpeed;
    }
}
