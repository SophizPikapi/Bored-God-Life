using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CalendarRandom : MonoBehaviour
{
    //public CalendarChoice choice;
    public GameManager refToGM;
    public int randomCalendar;
    public int calendarSpot;
    public int textSpot;
    public int randomText;
    public TextMeshPro refToText;
    public List<GameObject> TextList = new List<GameObject>();
    public List<GameObject> calendarList = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        randomCalendar = Random.Range(0, calendarList.Count);
        randomText = Random.Range(0, TextList.Count);

        calendarList[randomCalendar].GetComponent<SpriteRenderer>().color = Color.white;
        calendarList[randomCalendar].GetComponent<CalendarChoice>().isMeteor = true;
        refToText.transform.position = calendarList[randomCalendar].transform.position;

        calendarList.RemoveAt(randomCalendar);
        TextList.RemoveAt(randomText);

        for (int i = 0; i < calendarList.Count; i++)
        {
            calendarSpot = Random.Range(0, calendarList.Count);
            textSpot = Random.Range(0, TextList.Count);
            print("TEST");
            TextList[textSpot].transform.position = calendarList[calendarSpot].transform.position;
        }
        //use get component to the randomly chosen date, access the script of that, 
    }

    // Update is called once per frame
    void Update()
    {

    }
}
