using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderHolderScript : MonoBehaviour
{

    private Transform frontWall, backWall;
    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        frontWall = GameObject.Find("FrontWall").GetComponent<Transform>();
        backWall = GameObject.Find("DeathWall").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(-5, 0, 0);

        UpdateBorderPosition();
    }

    private void UpdateBorderPosition()
    {
        frontWall.position = new Vector3(transform.position.x - 10, 1, 0);
        backWall.position = new Vector3(transform.position.x + 10, 1, 0);
    }
}
