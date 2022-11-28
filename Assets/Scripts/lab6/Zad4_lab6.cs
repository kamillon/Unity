using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad4_lab6 : MonoBehaviour
{
    public CharacterController controller;
    private Vector3 playerVelocity;
    private float jumpHeight = 3.0f;
    private float gravityValue = -9.81f;

    private void OnTriggerEnter(Collider other)
    {
        playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        controller.Move(playerVelocity * Time.deltaTime);
    }
}
