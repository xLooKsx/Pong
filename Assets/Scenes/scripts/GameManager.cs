using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform ballSpawnPoint;

    public TextMeshProUGUI PlayerScoreLabel;
    public TextMeshProUGUI CpuScoreLabel;

    private int playerScore = 0;
    private int cpuScore = 0;

    void Start()
    {
        PlayerScoreLabel.text = playerScore.ToString();
        CpuScoreLabel.text = cpuScore.ToString();
    }

    public void ResetBallPosition()
    {
        GameObject.Instantiate(ballPrefab, ballSpawnPoint);
    }

    public void UpdateScore(bool isPlayerGoal)
    {
        if (isPlayerGoal)
        {
            this.cpuScore++;
            CpuScoreLabel.text = cpuScore.ToString();
        }
        else
        {
            this.playerScore++;
            PlayerScoreLabel.text = playerScore.ToString();            
        }
    }
}
