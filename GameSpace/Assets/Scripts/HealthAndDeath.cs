using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthAndDeath : MonoBehaviour
{
    //player Health
    public float Health = 3;
    //Meteor damage
    public float MeteorDamage = 1;



    public void Start()
    {
        Debug.Log("Starting health:" + Health);
    }
    private void OnTriggerEnter(Collider collission)
    {
        if (collission.transform.CompareTag("Meteor"))
        {
            //check if collision is detected
            Debug.Log("Ship hit a meteor");

            //damage the ship by one.
            Health -= MeteorDamage;
            Debug.Log($"Health: {Health}");


        }
        if (Health >= 0) 
        {
            Debug.Log("Ur dead lol");

        }
    }


}
