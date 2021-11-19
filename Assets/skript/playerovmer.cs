using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerovmer : MonoBehaviour
{
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddRelativeTorque(Vector3.left * -10000000f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddRelativeTorque(Vector3.left * 10000000f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddRelativeTorque(Vector3.up * 10000000f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddRelativeTorque(Vector3.up * -10000000f);
        }
    }
}
