using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthAndDeath : MonoBehaviour
{
    //player Health
    [SerializeField] private float Health = 5;
    //Meteor damage
    [SerializeField] private float MeteorDamage = 1;
    [SerializeField] private float BeamDamage = 3;
    [SerializeField] private float delay = 3f;
    [SerializeField] private GameObject effect;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip bomb;
    [SerializeField] private float bulletDamage = 1;
    [SerializeField] internal bool shieldActive = false;

    



    public void Start()
    {
        Debug.Log("Starting health:" + Health);

    }


    private void OnTriggerEnter(Collider collission)
    {
        if (!shieldActive)
        {
            //if the object the ship collides with has the tag meteor and if health is greater than zero:
            if (collission.transform.CompareTag("Meteor") && Health > 0)
            {
                //check if collision is detected


                //damage the ship by one.
                Health -= MeteorDamage;


                //if health is smaller than or equal to zero:

            }
            if (collission.transform.CompareTag("Beam"))
            {
                Health -= MeteorDamage;
            }
            if (collission.transform.CompareTag("EnemyBullet"))
            {
                Health -= bulletDamage;

            }
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



