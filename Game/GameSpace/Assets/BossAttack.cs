using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BossAttack : MonoBehaviour

{
    public GameObject ray;
    public GameObject dangerSign;
    public float interval;

    public Transform point;

    void Start()
    {
        StartCoroutine(spawnAttack(interval, dangerSign, ray));
        point = GameObject.Find("EnemySpawner").GetComponent<Transform>();
    }

    private IEnumerator spawnAttack(float interval, GameObject ray, GameObject dangerSign)
    {
        yield return new WaitForSeconds(interval);
        Vector3 spawnPoint = new Vector3(point.position.x, point.position.y, point.position.z + Random.Range(7, -7));
        Quaternion rotation = Quaternion.Euler(point.rotation.x, point.rotation.y - 90, point.rotation.z);
        GameObject newRay = Instantiate( ray, spawnPoint, rotation);
        GameObject newDangerSign = Instantiate(dangerSign, spawnPoint, rotation);
        StartCoroutine(spawnAttack(interval, dangerSign, ray));

    }
}

