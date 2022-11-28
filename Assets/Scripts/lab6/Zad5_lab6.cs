using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad5_lab6 : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Dosz³o do kontaktu");
        }
    }
}
