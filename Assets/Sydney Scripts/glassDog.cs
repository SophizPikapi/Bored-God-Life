using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glassDog : MonoBehaviour
{
    public GameObject spawn1;
    public GameObject spawn2;
    public GameObject spawn3;
    public int pickSpawn;
    // Start is called before the first frame update
    void Start()
    {
        pickSpawn = Random.Range(0, 3);
    }

    // Update is called once per frame
    void Update()
    {
        if (pickSpawn == 0)
        {
            this.transform.position = spawn1.transform.position;
        }

        if (pickSpawn == 1)
        {
            this.transform.position = spawn2.transform.position;
        }

        if (pickSpawn == 2)
        {
            this.transform.position = spawn3.transform.position;
        }
    }
}
