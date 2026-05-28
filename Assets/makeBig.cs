using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeBig : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        this.transform.localScale += new Vector3(0.1f, 0.1f, 0.1f);

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
            this.transform.localScale -= new Vector3(0.1f, 0.1f, 0.1f);
    }
}
