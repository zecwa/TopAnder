using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveblock : MonoBehaviour
{
    public float speed;
    private Vector3 pos;
    private bool isStop = false;
    // Start is called before the first frame update
    void Start()
    {
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(isStop)
        {
            pos.x += Time.deltaTime * speed;
            transform.position = pos;
            if(pos.x>15)
            {
                isStop = true;
            }
        }
        else
        {
            pos.x -= Time.deltaTime * speed;
            transform.position = pos;

            if (pos.x < 0) 
            {
                isStop = false;
            }
        }

    }
}
