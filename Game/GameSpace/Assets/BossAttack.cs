using System.Collections;
using System.Collections.Generic;

using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class BossAttack : MonoBehaviour
{
    public GameObject ray;
    public GameObject dangerSign;
    public float rayInternval;
    public Transform point;
    public float location;
    public float delay;

    void Start()
    {
        StartCoroutine(spawnRay(rayInternval, ray, dangerSign));
        point = GameObject.Find("Boss").GetComponent<Transform>();

       
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Pos = transform.position;
    }

    private IEnumerator spawnRay(float interval, GameObject ray,GameObject dangerSign)
    {
        yield return new WaitForSeconds(interval);
        Vector3 spawnPoint = new Vector3(point.position.x , point.position.y, point.position.z + Random.Range(7, -7));
        Vector3 location = dangerSign.transform.position = new Vector3(spawnPoint.x + 30, spawnPoint.y + 0, spawnPoint.z + 0);
        Quaternion rotation = Quaternion.Euler(point.rotation.x, point.rotation.y - 90, point.rotation.z);
        GameObject newRay = Instantiate(ray, spawnPoint, rotation);
       // GameObject newSign = Instantiate(dangerSign, spawnPoint, location, rotation);
        StartCoroutine(spawnRay(interval, ray, dangerSign));

    }


}

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


