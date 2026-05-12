using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CalendarRandom : MonoBehaviour
{
    //public CalendarChoice choice;
    public GameManager refToGM;
    public GameObject[] calendarList;
    public int randomCalendar;
    public TextMeshPro refToText;
    // Start is called before the first frame update
    void Start()
    {
        randomCalendar = Random.Range(0, calendarList.Length);
        calendarList[randomCalendar].GetComponent<SpriteRenderer>().color = Color.green;
        calendarList[randomCalendar].GetComponent<CalendarChoice>().isMeteor = true;
        //use get component to the randomly chosen date, access the script of that, 
    }

    // Update is called once per frame
    void Update()
    {

    }
}
