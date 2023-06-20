using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    //Gun Variables
    public Transform BulletSpawnPosition;
    public GameObject BulletPrefab;
    public float bulletSpeed;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Instantiate(BulletPrefab, BulletSpawnPosition.position, BulletSpawnPosition.rotation);
        }
        
    }
}
