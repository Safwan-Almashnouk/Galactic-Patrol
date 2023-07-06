using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;

public class Score : MonoBehaviour
{
    public float playerScore = 0f;
    public TextMeshProUGUI scoreText;
    public manager gm_manager;
    

    private void Update()
    {
        addScore();
    }

    [ContextMenu("Increase Score")]
    public void addScore()
    {
       
        playerScore = playerScore + Time.deltaTime;
        scoreText.text = Mathf.Floor(playerScore).ToString();
        gm_manager.playerScore = playerScore;
    }
 
}
