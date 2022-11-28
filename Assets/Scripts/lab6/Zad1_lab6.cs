using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad1_lab6 : MonoBehaviour
{
    public Vector3 destination;
    public float speed = 2;
    private bool goBack = false;
    private bool isMoving = false;
    private Vector3 startPosition;
    private Vector3 newPos;

    private void Start()
    {
        startPosition = transform.position;
        newPos = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
    }

    public void FixedUpdate()
    {
        if (transform.position == destination && isMoving)
        {
            newPos = startPosition;
            isMoving = true;
            goBack = true;
        }
        else if (transform.position == startPosition && isMoving)
        {
            newPos = destination;
            if (goBack)
            {
                isMoving = false;
            }
            else
            {
                isMoving = true;
            }
        }

        if (isMoving == true)
        {
            Debug.Log(newPos);
            transform.position = Vector3.MoveTowards(transform.position, newPos, speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(transform);
            isMoving = true;
            goBack = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.SetParent(null);
        isMoving = false;
    }
}
