using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElecMove : MonoBehaviour
{

    bool arrived;
    // Start is called before the first frame update
    void Start()
    {
        arrived = false;
    }

    // Update is called once per frame
    void Update()
    {
        // 2.904, -1.27     
        if(!arrived)
        {
            //transform.position.x == -.566f && transform.position.y == .127f
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(2.61f, -1.343f), 1f * Time.deltaTime);
            if (transform.position.x == 2.61f && transform.position.y == -1.343f)
            {
                arrived = true;
            }
        }
        if(arrived) //(-1.537f, 0.062f)
        {
            //transform.position = Vector2.MoveTowards(transform.position, new Vector2(.917f, 0.233f), 1f * Time.deltaTime);
        }
    }
}
