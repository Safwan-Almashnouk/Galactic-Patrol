using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPos : MonoBehaviour
{

    Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("ship").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.position.x + -20, transform.position.y);
    }
}

