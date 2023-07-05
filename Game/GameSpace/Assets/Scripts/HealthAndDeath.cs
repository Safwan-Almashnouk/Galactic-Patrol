using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthAndDeath : MonoBehaviour
{
    //player Health
    public float Health;
    //Meteor damage
    public float MeteorDamage = 1;
    public float BeamDamage = 3;
    public float delay = 3f;
    public GameObject effect;
    public AudioSource audioSource;
    public AudioClip bomb;
    public float bulletDamage = 1;




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

        }

        if (collission.transform.CompareTag("Beam"))
        {
            Health -= MeteorDamage;
            Debug.Log("you got hit");
        }
        if (collission.transform.CompareTag("EnemyBullet") && Health < 0)
        {
            Health -= bulletDamage;
        }

        if (Health <= 0)
        {
            Exploison();
        }
    }
    async private void OpenScene()
    {
        await Task.Delay(7000);
        SceneManager.LoadScene(sceneName: "GameOver");

    }

    public void Exploison()
    {
        Vector3 position = transform.position;
        for (int i = 0; i < 5; i++)
        {
            GameObject effects = Instantiate(effect, position, Quaternion.identity);
            effects.transform.SetParent(transform, true);
            effects.GetComponent<BoomScript>().enabled = false;
            gameObject.GetComponent<Movement>().enabled = false;
            audioSource.PlayOneShot(bomb, 0.5f);
            Destroy(effects, delay);
        }

        OpenScene();

    }
}



