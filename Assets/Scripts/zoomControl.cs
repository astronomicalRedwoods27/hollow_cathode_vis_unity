using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zoomControl : MonoBehaviour
{
    public float cameraZoom = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {   
            if (cameraZoom > 1)
            {
                Debug.Log("Left mouse down. Zoom in.");
                cameraZoom -= 1;
            }
        }
        if (Input.GetMouseButtonDown(1))
        {
            if (cameraZoom < 5)
            {
                Debug.Log("Right mouse down. Zoom out.");
                cameraZoom += 1;
            }
        }
        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("Middle mouse down. View reset.");
            cameraZoom = 5;            
        }

        GetComponent<Camera> ().orthographicSize = cameraZoom;
    }
}
