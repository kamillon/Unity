using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Zadanie1_lab4 : MonoBehaviour
{
    List<Vector3> positions = new List<Vector3>();
    public List<Material> materials = new List<Material>();
    public float delay = 3.0f;
    int objectCounter = 0;
    public GameObject block;
    public int numberOfObjects;
    private Renderer r;

    void Start()
    {
        r = GetComponent<Renderer>();

        int minBoundX = (int)r.bounds.min.x;
        int maxBoundX = (int)r.bounds.max.x;
        int minBoundZ = (int)r.bounds.min.z;
        int maxBoundZ = (int)r.bounds.max.z;

        List<int> pozycje_x = new List<int>(Enumerable.Range(minBoundX, maxBoundX - minBoundX).OrderBy(x => Guid.NewGuid()).Take(numberOfObjects));
        List<int> pozycje_z = new List<int>(Enumerable.Range(minBoundZ, maxBoundZ - minBoundZ).OrderBy(x => Guid.NewGuid()).Take(numberOfObjects));

        for (int i = 0; i < numberOfObjects; i++)
        {
            this.positions.Add(new Vector3(pozycje_x[i], 0.5f, pozycje_z[i]));
        }
        foreach (Vector3 elem in positions)
        {
            Debug.Log(elem);
        }
        StartCoroutine(GenerujObiekt());
    }

    IEnumerator GenerujObiekt()
    {
        foreach (Vector3 pos in positions)
        {
            Instantiate(this.block, this.positions.ElementAt(this.objectCounter++), Quaternion.identity);
            this.block.GetComponent<Renderer>().material = materials[UnityEngine.Random.Range(0, materials.Count)];
            yield return new WaitForSeconds(this.delay);
        }
        StopCoroutine(GenerujObiekt());
    }
}