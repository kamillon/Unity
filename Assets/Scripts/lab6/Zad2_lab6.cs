using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad2_lab6 : MonoBehaviour
{
    public GameObject door;
    public float speed = 4f;
    private bool isOpen;
    private float maximumOpening;
    private float maximumClosing;
    public float distance = 4f;

    void Start()
    {
        isOpen = false;
        maximumOpening = door.transform.position.x + distance;
        maximumClosing = door.transform.position.x;
}

    void Update()
    {
        if (isOpen)
        {
            if(door.transform.position.x < maximumOpening)
            {
                door.transform.Translate(speed * Time.deltaTime, 0f, 0f);
            }
        }
        else
        {
            if (door.transform.position.x > maximumClosing)
            {
                door.transform.Translate(-speed * Time.deltaTime, 0f, 0f);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isOpen = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            isOpen = false;
        }
    }
}
