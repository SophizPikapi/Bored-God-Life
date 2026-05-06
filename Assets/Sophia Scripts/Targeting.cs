using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Targeting : MonoBehaviour
{
    public CircleCollider2D cc;
    public GameManager refToGM;
    public GameObject refToStar;
    public Stars starShit;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        cc = GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition) + new Vector3(0, 0, 10);

     
    }
}
