using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CalendarRandom : MonoBehaviour
{
    public GameManager refToGM;
    public int randomCalendar;
    public int calendarSpot;
    public int textSpot;
    public int randomText;
    public TextMeshPro refToText;
    public List<GameObject> TextList = new List<GameObject>();
    public List<GameObject> calendarList = new List<GameObject>();

    void Start()
    {
        randomCalendar = Random.Range(0, calendarList.Count);
        randomText = Random.Range(0, TextList.Count);

        calendarList[randomCalendar].GetComponent<SpriteRenderer>().color = Color.white;
        calendarList[randomCalendar].GetComponent<CalendarChoice>().isMeteor = true;
        refToText.transform.position = calendarList[randomCalendar].transform.position;

        calendarList.RemoveAt(randomCalendar);
        TextList.RemoveAt(randomText);

        while (calendarList.Count > 0 && TextList.Count > 0)
        {
            calendarSpot = Random.Range(0, calendarList.Count);
            textSpot = Random.Range(0, TextList.Count);

            print("TEST");

            TextList[textSpot].transform.position = calendarList[calendarSpot].transform.position;

            // Remove used entries so they cannot be chosen again
            calendarList.RemoveAt(calendarSpot);
            TextList.RemoveAt(textSpot);
        }
    }

    void Update()
    {

    }
}