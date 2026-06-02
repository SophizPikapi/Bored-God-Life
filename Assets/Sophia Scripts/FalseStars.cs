using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FalseStars : MonoBehaviour
{
    public GameManager refToGM;
    public GameObject refToMouse;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetMouseButtonDown(0)) && (this.GetComponent<SpriteRenderer>().bounds.Intersects(refToMouse.GetComponent<CircleCollider2D>().bounds)))
        {
            refToGM.starLose = true;
        }
    }
}
