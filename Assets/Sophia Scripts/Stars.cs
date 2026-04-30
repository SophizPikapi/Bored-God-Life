using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour
{
    public GameManager refToGM;
    public GameObject refToMouse;
    public bool starLight;

    // Start is called before the first frame update
    void Start()
    {
        starLight = false;
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetMouseButtonDown(0)) && (this.GetComponent<SpriteRenderer>().bounds.Intersects(refToMouse.GetComponent<SpriteRenderer>().bounds)))
        {
            refToGM.starScore++;
            starLight = true;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
    }
}
