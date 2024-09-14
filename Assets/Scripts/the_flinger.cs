using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thefligner : MonoBehaviour
{   
    public Rigidbody rb;
    public float mag = 10f;

    // Start is called before the first frame update
    void Start()
    {
        //rb = Transform.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Random.Range(-mag, mag);
        float y = Random.Range(-mag, mag);
        float z = Random.Range(-mag, mag);
        rb.velocity += new Vector3(x,y,z);
    }
}
