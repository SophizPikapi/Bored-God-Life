using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseScreens : MonoBehaviour
{
    public RandomMenu rm;
    public GameManager refToGM;
    public GameObject winScreen;
    public GameObject loseScreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (refToGM.starWin)
        {
            winScreen.transform.position = new Vector3(0, 0.65f, 0);
        }
        if (rm.timer <= 0 && !refToGM.starWin)
        {
            loseScreen.transform.position = new Vector3(0, 0.65f, 0);
        }
    }
}
