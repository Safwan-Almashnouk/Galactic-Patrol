using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    //player Health
    public float Health;
    //Meteor damage
    public float MeteorDamage = 1;

    public void Start()
    {
        Debug.Log("Starting health:" + Health);
    }
    private void OnTriggerEnter(Collider collission)
    {
        //if the object the ship collides with has the tag meteor and if health is greater than zero:
        if (collission.transform.CompareTag("Meteor") && Health > 0)
        {
            //check if collision is detected
            Debug.Log("Ship hit a meteor");

            //damage the ship by one.
            Health -= MeteorDamage;
            Debug.Log($"Health: {Health}");

            //if health is smaller than or equal to zero:
            if (Health <= 0)
            {
                Debug.Log("Ur dead lol");
                SceneManager.LoadScene(sceneName: "GameOver");
            }
        }

    }


}