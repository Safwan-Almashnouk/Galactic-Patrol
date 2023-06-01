using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int Health = 3;

    public int Damage = 1;



    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
        if(collision.gameObject.name == "Meteor(Clone)")
        {
            Destroy(collision.gameObject);
            Health -= Damage;
            print(Health);
        }

        if(Health > 0)
        {

        }
    }
}
