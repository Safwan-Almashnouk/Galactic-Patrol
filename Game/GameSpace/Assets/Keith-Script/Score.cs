using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public float playerScore = 0;
    public TextMeshProUGUI scoreText;
    public manager gm_manager;

    private void Update()
    {
        addScore();
    }

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        Debug.Log("add score");
        playerScore = playerScore + Time.deltaTime;
        scoreText.text = Mathf.Floor(playerScore).ToString();
        gm_manager.playerScore = playerScore;
    }
}
