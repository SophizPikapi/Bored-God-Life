using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    public GameObject scoreKeeperThingy;
    // Start is called before the first frame update
    void Start()
    {
        scoreKeeperThingy = GameObject.FindGameObjectWithTag("scoreKeeper");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseDown()
    {
        Destroy(scoreKeeperThingy);
        SceneManager.LoadScene("Menu");
    }
}
