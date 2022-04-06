using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scene6Script : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            animator.SetTrigger("Scene6_trigger");
        }
    }
}
