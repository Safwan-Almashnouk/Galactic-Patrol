using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using UnityEngine.SceneManagement;

public class ScenTransition : MonoBehaviour
{
    private Animator ani;
    void Start()
    {        
        ani = GetComponent<Animator>();
    }

    public async void Delay()
    {
        await Task.Delay(500);
        // load scene
    }
    public void NextLevel()
    {
        ani.SetTrigger("End");
        Delay();
        if (gameObject.activeSelf)
        {
            
            ani.ResetTrigger("End");
        }
        if (gameObject.activeSelf)
        {
            ani.SetTrigger("End");
            ani.ResetTrigger("Start");
        }
    }
}
