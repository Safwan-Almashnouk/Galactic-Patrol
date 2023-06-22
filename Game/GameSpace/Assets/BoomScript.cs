using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BoomScript : MonoBehaviour
{
    Transform Boss;
    BossScript bossScript;
    Vector3 posRelativeToBoss;
    bool bossIsAlive = true;
    void Start()
    {
        Boss = GameObject.Find("Boss").GetComponent<Transform>();
        bossScript = Boss.GetComponent<BossScript>();
        posRelativeToBoss = transform.position - Boss.position;
        posRelativeToBoss.y += 5;
        posRelativeToBoss.x += Random.Range(1, 2);
        posRelativeToBoss.z+= Random.Range(15, -15);
    }

    // Update is called once per frame
    void Update()
    {
        if (bossIsAlive)
        {
            transform.position = Boss.position + posRelativeToBoss;
        }
        else
        {
            Destroy(gameObject, 0.5f);
        }

        if (bossScript.health <= 0)
        {
            StartCoroutine(WaitForDelay());
        }
        

    }
    IEnumerator WaitForDelay()
    {
        yield return new WaitForSeconds(4);
        bossIsAlive = false;
    }
}
