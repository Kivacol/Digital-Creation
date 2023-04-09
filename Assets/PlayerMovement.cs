using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public GameObject Camera;
    public float rotateSpeed = 10f;
    public Rigidbody rb;

    public test ultrasound;
    public float moveSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //鏡頭旋轉
        if (ultrasound.dis1 < 30)
        {
            Move();
        }
        else
        {
            Camera.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
            rb.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        }
    }

    public void Move()
    {
        if(ultrasound.dis1 < 5)
        {
            transform.Translate(Vector3.forward * moveSpeed * 2f * Time.deltaTime);
        }
        else if (ultrasound.dis1 < 10)
        {
            transform.Translate(Vector3.forward * moveSpeed * 1.5f * Time.deltaTime);
        }
        else if (ultrasound.dis1 < 20)
        {
            transform.Translate(Vector3.forward * moveSpeed * 1.2f * Time.deltaTime);
        }
        else if (ultrasound.dis1 < 30)
        {
            transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }
        //transform.localScale = new Vector3(ultrasound.dis1, ultrasound.dis1, ultrasound.dis1);
    }
}
