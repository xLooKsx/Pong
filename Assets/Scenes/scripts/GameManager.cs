using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform ballSpawnPoint;
    public void ResetBallPosition()
    {
        GameObject.Instantiate(ballPrefab, ballSpawnPoint);
    }
}
