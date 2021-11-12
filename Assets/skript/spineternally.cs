using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spineternally : MonoBehaviour
{
    public GameObject bruh;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var final = bruh.transform.rotation * Quaternion.Euler(45, 45, 45);
        bruh.transform.rotation = Quaternion.Lerp(transform.rotation, final, Time.deltaTime);
        
    }
}
