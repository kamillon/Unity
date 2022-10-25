using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie3 : MonoBehaviour
{
    public float speed = 2.0f;
    //public Vector3[] points;

    Vector3[] points = new[] { 
        new Vector3(-10f, 0f, 0f), 
        new Vector3(-10f, 0f, 10f),
        new Vector3(0f, 0f, 10f),
        new Vector3(0f, 0f, 0f),
    };

    private int nextPointIndex = 0;

    private void Update()
    {
        if (transform.position == points[nextPointIndex])
        {
            nextPointIndex++;
            if (nextPointIndex >= points.Length)
            {
                nextPointIndex = 0;
            }
            transform.Rotate(0, 90, 0);
        }

        transform.position = Vector3.MoveTowards(transform.position, points[nextPointIndex], speed * Time.deltaTime);
    }
}
