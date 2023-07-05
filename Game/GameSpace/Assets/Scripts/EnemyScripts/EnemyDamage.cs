using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    //Script is on the enemyShip.


    //class variables
    public float enemyHealth = 3;
    public float bulletDamage = 1;



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Enemy damage script active");
        Debug.Log($"Enemy starting health: {enemyHealth}");
    }

    private void OnTriggerEnter(Collider collision)
    {
        //check if collision is found
        if(collision.transform.CompareTag("Bullet") && enemyHealth > 0) 
        {
            // Checks if bullet hit the enemy
            Debug.Log("bullet hit the enemy!");

            //removes 1 hp from the ship
            enemyHealth -= bulletDamage;
            //destroys the bullet
            Destroy(collision.gameObject);

            //puts the health of the ship in the console.
            Debug.Log($"Enemy Health: {enemyHealth}");


            //if enemyHealth is smaller than or equal to 0
            if(enemyHealth <= 0)
            {
                Debug.Log("Enemy is dead!");

                //destroys the enemy ship
                Destroy(gameObject);
                
            }
        }
    }
}
