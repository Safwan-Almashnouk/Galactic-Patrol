using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pauze : MonoBehaviour
{
    public GameObject gameUI;
    public void AntiMove()
    { 
       gameUI.SetActive(false);
        Time.timeScale = 1;
    }
}
