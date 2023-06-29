using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using System.Threading.Tasks;

public class BossAttack : MonoBehaviour

{
    [SerializeField] private GameObject ray;
    [SerializeField] private GameObject dangerSign;
    [SerializeField] private float interval;
    private float time = 2.5f;
    private float timePassed = 0;
    [SerializeField] private GameObject player;
    [SerializeField] private AudioSource audioSource;


    [SerializeField] private AudioClip warning;
    [SerializeField] private AudioClip blast;

    [SerializeField] private Transform point;

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

            audioSource.PlayOneShot(warning, 1f);

        }
    }



    async private void spawnBeam(Vector3 spawnPoint, Quaternion rotation)
    {
        Quaternion rot = Quaternion.Euler(point.rotation.x , point.rotation.y -90, point.rotation.z + 90);
        await Task.Delay(1000);
        #if UNITY_EDITOR
        if (UnityEditor.EditorApplication.isPlaying)
        {
            GameObject newRay = Instantiate(ray, spawnPoint - new Vector3(80, 0, 0), rot);
            audioSource.PlayOneShot(blast, 0.8f);

        }
#endif

    }
}

