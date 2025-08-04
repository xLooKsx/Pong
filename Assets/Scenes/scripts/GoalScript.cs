using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{

    public GameManager gameManager;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {
            Debug.Log("gol!!!!!!!!!!!!!!!!");
            GameObject.Destroy(collision.gameObject);
            gameManager.ResetBallPosition();
        }
        
    }
}
