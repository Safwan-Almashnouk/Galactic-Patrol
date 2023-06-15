using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int Health = 3;

    public int Damage = 1;



    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.name == "Meteor(clone)")
        {
            //checks if meteor hits ship
            Debug.Log("Meteor hit ship");
        }
    }
}
