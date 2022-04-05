using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosMove : MonoBehaviour
{     
    bool Pstart;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale = new Vector2(0, 0);
    }

    // Update is called once per frame
    void Update()
    {     
        GameObject neut = GameObject.Find("neutralAtom");
        NeutMove move = neut.GetComponent<NeutMove>();
        Pstart = move.Narrived;
        
        if (Pstart)
        {
            transform.localScale = new Vector2(.25f, .25f);
            transform.position = Vector2.MoveTowards(transform.position, new Vector2(1.205f, -1.634f), 1f * Time.deltaTime);
        }
    }
}
