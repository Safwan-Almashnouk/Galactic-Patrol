using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class spawner : MonoBehaviour

{
     public GameObject enemy;

     public float enemyInterval;

    public Transform point;

    void Start()
    {
        StartCoroutine(spawnEnemy(enemyInterval, enemy));
        point = GameObject.Find("MeteorSpawner").GetComponent<Transform>();
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        Vector3 spawnPoint = new Vector3(point.position.x , point.position.y, point.position.z + Random.Range(7, -7));
        GameObject newEnemy = Instantiate(enemy, spawnPoint, Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
        GameObject spawned = Instantiate(enemy);
        spawned.transform.localRotation = Quaternion.Euler(new Vector3(0, Random.Range(0f, 360f), 0));

    }
}