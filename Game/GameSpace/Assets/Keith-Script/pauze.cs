using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauze : MonoBehaviour
{
    public GameObject PauzeMenu;

    public bool isPaused;

    private void Start()
    {
        PauzeMenu.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        PauzeMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused= true;
    }

    public void ResumeGame()
    {
        PauzeMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused= false;
    }
}
