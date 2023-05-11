using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorMovment : MonoBehaviour

    
{
    public float speed = 30f;

    private void Start()
    {
        StartCoroutine(SelfDestruct());
    }
    public void Update()
    {
        transform.position += transform.right * speed * Time.deltaTime;
    }
    IEnumerator SelfDestruct()
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);
    }
}
