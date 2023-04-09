using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    public test ultrasound;

    public float rotateSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetSize();

        transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
    }

    public void SetSize()
    {
        transform.localScale = new Vector3(ultrasound.dis1, ultrasound.dis1, ultrasound.dis1);
    } 
}
