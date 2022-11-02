using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zadanie3_4_lab4 : MonoBehaviour
{
    public Transform player;

    public float sensitivity = 200f;
    private float xRotate = 0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseXMove = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float mouseYMove = Input.GetAxis("Mouse Y") * sensitivity * Time.deltaTime;

        player.Rotate(Vector3.up * mouseXMove);

        xRotate -= mouseYMove;
        xRotate = Mathf.Clamp(xRotate, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotate, 0f, 0f);
    }
}
