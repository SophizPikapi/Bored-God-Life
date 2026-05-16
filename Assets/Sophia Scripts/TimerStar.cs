using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerStar : MonoBehaviour
{
    public GameManager refToGM;
    public RandomMenu rm;
    public float totalTimer = 10f;
    public float delayTimer = 3f;
    public bool totalTrue;
    public bool delayTrue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (rm.gameStart)
        {
            totalTrue = true;

            if (totalTrue)
            {
                totalTimer -= Time.deltaTime;
            }
            else if (totalTimer <= 0)
            {
                delayTrue = true;
                Debug.Log("LIFE LOST");
            }
            else if (refToGM.starWin || refToGM.mouseWin || refToGM.calendarWin || refToGM.dogWin)
            {
                delayTrue = true;
                Debug.Log("POINT GAINED");
            }
            if (delayTrue)
            {
                delayTimer -= Time.deltaTime;
                totalTrue = false;
            }
            else if (delayTimer <= 0)
            {
                rm.Randomisation();
                delayTimer = 3f;
                totalTimer = 10f;
                delayTrue = false;
                totalTrue = true;
            }
        }
    }
}
