using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgScroll : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 StartPosition;

    private void Start()
    {
        StartPosition = transform.position; 

    }

    private void Update()
    {
        transform.Translate(translation: Vector3.down * speed * Time.deltaTime);
        if (transform.position.y < 1.109034)
        {
            transform.position = StartPosition;
        }
    }
}
