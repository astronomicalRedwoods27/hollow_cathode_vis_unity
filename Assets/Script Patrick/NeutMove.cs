using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeutMove : MonoBehaviour
{
    public bool Narrived;
    // Start is called before the first frame update
    void Start()
    {
        Narrived = false;
    }

    // Update is called once per frame
    void Update()
    {
        // 2.07, -1.63
        if (!Narrived)
        {
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(2.316f, -1.522f), 1f * Time.deltaTime);
            if (transform.position.x == 2.316f && transform.position.y == -1.522f)
            {               
                Narrived = true;
                transform.localScale = new Vector2(0,0);
            }
        }
    }
}
