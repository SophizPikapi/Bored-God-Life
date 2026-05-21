using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointKeeper : MonoBehaviour
{
    public static int score = 0;
    public static int livesLeft = 3;
    public GameObject refToGM;
    public static PointKeeper selfRef;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        refToGM = GameObject.FindGameObjectWithTag("GM");
    }
}
