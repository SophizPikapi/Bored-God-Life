using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalendarChoice : MonoBehaviour
{
    public GameManager refToGM;
    public bool isMeteor = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        if (isMeteor)
        {
            refToGM.calendarWin = true;
            Debug.Log("YOU WIN");
        }
        else if (!isMeteor)
        {
            refToGM.calendarLose = true;
        }
    }
}
