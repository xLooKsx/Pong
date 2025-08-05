using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalScript : MonoBehaviour
{
    public bool IsPlayerGoal;
    public GameManager gameManager;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ball"))
        {            
            GameObject.Destroy(collision.gameObject);
            gameManager.UpdateScore(IsPlayerGoal);
            gameManager.ResetBallPosition();
        }
        
    }
}
