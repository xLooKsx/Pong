using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movementSpeed;

    private Rigidbody2D myRigidbody2D;
    private float verticalMovement;

    void Start()
    {
        myRigidbody2D = this.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        verticalMovement = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        Vector2 movement = new Vector2(0, verticalMovement) * movementSpeed;
        myRigidbody2D.AddForce(movement);
    }
}
