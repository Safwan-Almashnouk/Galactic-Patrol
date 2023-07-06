using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BossScript : MonoBehaviour
{

    private Rigidbody obj;
    [SerializeField] internal float health = 250;
    [SerializeField] private GameObject effect;
    [SerializeField] private float delay = 5f;
    bool triggeredRunAway = false;
    [SerializeField] private AudioSource Napalm;
    private BossAttack bossStop;

    
    private void Start()
    {
        obj = GetComponent<Rigidbody>();
        
    }

    private void Update()
    {
        
         
        if(triggeredRunAway == false && health > 0)
        {
            obj.velocity = new Vector3(-5, 0, 0);
        }


       else if (triggeredRunAway == false && health <= 0)
        {
            triggeredRunAway = true;
            StartCoroutine(escape());
            Destroy(gameObject, 10);
            StartCoroutine(over());
        }

    }

    IEnumerator escape()
    {
        Debug.Log("i will run");
        yield return new WaitForSeconds(5f);
        obj.velocity = new Vector3(-10, 0, 0);
        
    }
    IEnumerator over()
    {
        
        yield return new WaitForSeconds(8f);
        SceneManager.LoadScene(sceneName: "GameOver");

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Bullet(Clone)")
        {
            health = health - 1;
            
        }
        if (health <= 0) 
        {for (int i=0; i<5; i++)
        {
            GameObject effects = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(effects, delay);
        }
            gameObject.GetComponent<BossAttack>().enabled= false;
            
        }
        if(health == 0)
        {
            Napalm.Play();
        }
    }

    
}
