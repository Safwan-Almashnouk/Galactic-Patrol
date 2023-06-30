using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{
    public float playerScore;
    public string scoreText;
    public static manager instantce;
    // Start is called before the first frame update
    void Start()
    {
     if(instantce != null)
        {
            Destroy(this.gameObject);
            return;
        }   
    }

    // Update is called once per frame
    void Update()
    {
        instantce = this;
        DontDestroyOnLoad(this.gameObject);
    }
}
