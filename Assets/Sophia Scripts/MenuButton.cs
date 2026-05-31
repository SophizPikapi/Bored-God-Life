using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    GameObject pointKeeper;
    // Start is called before the first frame update
    void Start()
    {
        pointKeeper = GameObject.FindGameObjectWithTag("scoreKeeper");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        Destroy(pointKeeper);

        SceneManager.LoadScene("Menu");
    }
}
