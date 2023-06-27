using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemySpawner : MonoBehaviour

{
    public GameObject enemy;

    public float enemyInterval;

    public Transform point;

    void Start()
    {
        StartCoroutine(spawnEnemy(enemyInterval, enemy));
        point = GameObject.Find("EnemySpawner").GetComponent<Transform>();
    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy)
    {
        yield return new WaitForSeconds(interval);
        Vector3 spawnPoint = new Vector3(point.position.x, point.position.y, point.position.z + Random.Range(7, -7));
        Quaternion rotation = Quaternion.Euler(point.rotation.x, point.rotation.y - 90, point.rotation.z);
        GameObject newEnemy = Instantiate(enemy, spawnPoint, rotation);
        StartCoroutine(spawnEnemy(interval, enemy));

    }
}
