using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraraycaster : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray topLeft = Camera.main.ScreenPointToVector3(new Vector3(0, 0, 0));
        Ray topRight = Camera.main.ScreenPointToRay(new Vector3(Screen.width, 0, 0));
        Ray botRight = Camera.main.ScreenPointToRay(new Vector3(Screen.width, Screen.height, 0));
        Ray botLeft = Camera.main.ScreenPointToRay(new Vector3(0, Screen.height, 0));
    }
}
