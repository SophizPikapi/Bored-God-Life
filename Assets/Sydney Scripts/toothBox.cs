using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toothBox : MonoBehaviour
{
    public GameObject refToSharkManager;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "badTooth")
        {
            refToSharkManager.GetComponent<sharkManagerScript>().collectedTeeth += 1;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "badTooth")
        {
            refToSharkManager.GetComponent<sharkManagerScript>().collectedTeeth -= 1;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
