using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSponerScript : MonoBehaviour
{
    public GameObject pipes;
    public float sponRate = 2;
    public float spawnOffset = 5;
    private float timer = 0; 
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < sponRate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }
    void spawnPipe()
    {
        float highestPoint = transform.position.y + spawnOffset;
        float lowestPoint = transform.position.y - spawnOffset;
        Vector3 spwanPoint = new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), transform.position.z);
        Instantiate(pipes, spwanPoint, transform.rotation);
    }
}
