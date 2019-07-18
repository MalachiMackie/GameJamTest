using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject[] Checkpoints = new GameObject[2];
    private int nextPoint;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Checkpoints[0].transform.position;
        nextPoint = 0;

    }

    // Update is called once per frame
    void Update()
    {
        var distance = transform.position - Checkpoints[nextPoint].transform.position;
        if (distance.magnitude < 0.1)
        {
            nextPoint++;
        }

        if (nextPoint >= Checkpoints.Length)
        {
            nextPoint = 0;
        }

        transform.position = Vector3.MoveTowards(transform.position, Checkpoints[nextPoint].transform.position, 0.3f);

    }
}
    