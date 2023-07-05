using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBulletMovement : MonoBehaviour
{

    public float bulletSpeed;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(bulletSpeed, 0, 0) * Time.deltaTime;
    }
}
