using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public class meteorshowerdate : MonoBehaviour
{
    public bool use;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void FixedUpdate()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
    }

    void OnMouseOver()
    {
        if (Input.GetMouseButton(0))
        {
            use = true;
            SceneManager.LoadScene("");
        }
    }
}
