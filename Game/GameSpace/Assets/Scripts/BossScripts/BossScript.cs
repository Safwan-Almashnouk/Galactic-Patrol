using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{

    private Rigidbody obj;
    public float health = 5;
    public GameObject effect;
    public float delay = 5f;
    bool triggeredRunAway = false;
    public AudioSource Napalm;
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
            StartCoroutine(runbitch());
            Destroy(gameObject, 10);
        }

    }

    IEnumerator runbitch()
    {
        Debug.Log("i will run");
        yield return new WaitForSeconds(5f);
        obj.velocity = new Vector3(-10, 0, 0);
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "Bullet(Clone)")
        {
            health = health - 1;
            Debug.Log(health);
        }
        if (health <= 0) 
        {
            GameObject effects = Instantiate(effect, transform.position, Quaternion.identity);
            GameObject effects2 = Instantiate(effect, transform.position, Quaternion.identity);
            GameObject effects3 = Instantiate(effect, transform.position, Quaternion.identity);
            GameObject effects4 = Instantiate(effect, transform.position, Quaternion.identity);
            Destroy(effects,delay);
            Destroy(effects2, delay);
            Destroy(effects3, delay);
            Destroy(effects4, delay);
            gameObject.GetComponent<BossAttack>().enabled= false;
            
        }
        if(health == 0)
        {
            Napalm.Play();
        }
    }

    
}
