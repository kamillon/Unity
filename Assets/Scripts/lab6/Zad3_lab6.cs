using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad3_lab6 : MonoBehaviour
{
    public List<Vector3> waypoints = new List<Vector3>();
    public float speed = 2;
    int index = 0;
    private bool isBack = false;
    private bool isMoving = false;

    public void FixedUpdate()
    {
        Vector3 target = waypoints[index];
        Vector3 newPos = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (isMoving == true)
        {
            transform.position = newPos;
        }

        float distance = Vector3.Distance(transform.position, target);
        if (distance <= 0.05)
        {
            if (index < waypoints.Count - 1 && !isBack)
            {
                index++;
            }
            else
            {
                if (index == 0)
                {
                    isBack = false;
                    isMoving = false;
                }
                else
                {
                    isBack = true;
                    index--;
                }
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.transform.SetParent(transform);
            isMoving = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        other.transform.SetParent(null);
        isMoving = false;
    }
}
