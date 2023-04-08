using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    public test ultrasound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SetSize();
    }

    public void SetSize()
    {
        transform.localScale = new Vector3(ultrasound.dis1, ultrasound.dis1, ultrasound.dis1);
    } 
}
