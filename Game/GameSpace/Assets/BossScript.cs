using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{

    private Rigidbody obj;
    public float health = 5;
    public GameObject effect;
    public float delay = 5f;
    
    private void Start()
    {
        obj = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        obj.velocity = new Vector3(-5, 0, 0);

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
            Destroy(gameObject, delay);
            GameObject effects = Instantiate(effect, transform.position, Quaternion.identity);
        }
    }
}
