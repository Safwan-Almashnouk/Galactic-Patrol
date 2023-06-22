using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    public GameObject gameUI;
    public void Move()
    {
        gameUI.SetActive(false);
        Time.timeScale = 0;
    }
}
