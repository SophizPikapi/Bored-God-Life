using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointKeeper : MonoBehaviour
{
    public int score;
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
