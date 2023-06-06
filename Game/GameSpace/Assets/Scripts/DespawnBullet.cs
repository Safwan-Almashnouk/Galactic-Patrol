using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DespawnBullet : MonoBehaviour
{
    public float life = 1.5f;
    public GameObject bulletPrefab;
    public GameObject meteorPrefab;

    public void Awake()
    {
        Destroy(bulletPrefab, life);
    }

    void OnTriggerEnter(Collider collider)
    { 
            Destroy(collider.gameObject);

    }
}
