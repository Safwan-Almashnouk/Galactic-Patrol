using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using System.Threading.Tasks;

public class BossAttack : MonoBehaviour

{
    public GameObject ray;
    public GameObject dangerSign;
    public float interval;
    private float time = 5;
    private float timePassed = 0;
    public GameObject player;

    public Transform point;

    void Start()
    {

        point = GameObject.Find("Boss").GetComponent<Transform>();
    }

    private void Update()
    {
        timePassed += Time.deltaTime;
        if (timePassed > time)
        {
            timePassed = 0;
            Vector3 spawnPoint = new Vector3(point.position.x, point.position.y, player.transform.position.z);
            Quaternion rotation = Quaternion.Euler(point.rotation.x + 90, point.rotation.y - 90, point.rotation.z);
            GameObject newDangerSign = Instantiate(dangerSign, spawnPoint + new Vector3(35, 0, 0), rotation);
            spawnBeam(spawnPoint, rotation);

        }
    }



    async private void spawnBeam(Vector3 spawnPoint, Quaternion rotation)
    {
        Quaternion rot = Quaternion.Euler(point.rotation.x , point.rotation.y + 90, point.rotation.z + 90);
        await Task.Delay(1000);
        GameObject newRay = Instantiate(ray, spawnPoint - new Vector3(80, 0,0), rot);
    }
}

