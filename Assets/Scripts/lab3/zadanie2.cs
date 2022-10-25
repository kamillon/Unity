using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie2 : MonoBehaviour
{
    public float speed = 1.0f;
    private Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= 0)
        {
            target = new Vector3(10, 0, 0);
        }
        else if (transform.position.x >= 10)
        {
            target = new Vector3(0, 0, 0);
        }
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }

}