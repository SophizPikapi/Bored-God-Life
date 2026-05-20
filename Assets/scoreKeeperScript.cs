using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreKeeperScript : MonoBehaviour
{
    public static int score;
    public GameManager refToGM;
    public static scoreKeeperScript selfRef;

    // Start is called before the first frame update
    void Start()
    {
        selfRef = this;
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
