using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    Scene scene;

    // Start is called before the first frame update
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    void Update()
    {
        // move forward
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (scene.buildIndex < 5)
            {
                SceneManager.LoadScene(scene.buildIndex + 1);  
            }
        }

        // move backward
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (scene.buildIndex > 0)
            {
                SceneManager.LoadScene(scene.buildIndex - 1);
            }
        }
    }
}
