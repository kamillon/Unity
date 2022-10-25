using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zadanie5 : MonoBehaviour
{
    public GameObject prefab;
    public List<Vector3> positions;

    void Start()
    {
        if (prefab == null) return;
        for (int i = 0; i < 10; i++)
        {
            Vector3 randomPoint = GetRandomPoint();
            while (positions.Contains(randomPoint))
            {
                randomPoint = GetRandomPoint();
            }
            positions.Add(randomPoint);
            Instantiate(prefab, randomPoint, Quaternion.identity);
        }
    }

    Vector3 GetRandomPoint()
    {
        int xRandom = 0;
        int zRandom = 0;

        xRandom = Random.Range(-10, 10);
        zRandom = Random.Range(-10, 10);

        return new Vector3(xRandom, 0.5f, zRandom);
    }
}
