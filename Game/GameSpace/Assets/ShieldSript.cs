using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldSript : MonoBehaviour
{
    bool shieldstatus = false;

    public GameObject pickupEffect;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ItamBox"))
        {
            Pickup(other);
        }

    }

    void Pickup(Collider shield)
    {
        shieldstatus = !shieldstatus;
        shield.gameObject.SetActive(shieldstatus);

        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<Collider>().enabled = false;  
        
        Destroy(gameObject);
        Debug.Log("Power up pick up!");
    }

}
