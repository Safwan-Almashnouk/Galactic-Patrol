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
            audioSource.PlayOneShot(blast, 0.4f);

        }
#endif

    }
}


