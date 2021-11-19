using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafolower : MonoBehaviour
{
    public GameObject playah;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(playah.transform.position.x, playah.transform.position.y + 0.9f, playah.transform.position.z);
        /*Ray topLeft = Camera.main.ScreenPointToVector3(new Vector3(0, 0, 0));
        Ray topRight = Camera.main.ScreenPointToRay(new Vector3(Screen.width, 0, 0));
        Ray botRight = Camera.main.ScreenPointToRay(new Vector3(Screen.width, Screen.height, 0));
        Ray botLeft = Camera.main.ScreenPointToRay(new Vector3(0, Screen.height, 0));
        */
    }
}
