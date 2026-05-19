using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager selfRef;

    public float timer = 10f;

    public int pointScored;
    public int difficultyLevel;
    public int gameLoop;
    public int gameLives;

    public bool gameStart;

    [Header("Win Conditions")]
    public bool dogWin = false;
    public bool calendarWin = false;
    public bool starWin = false;
    public bool mouseWin = false;
    public bool sharkWin = false;
    public bool keyboardWin = false;

    [Header("Played Conditions")]
    public bool dogPlayed;
    public bool calendarPlayed;
    public bool starPlayed;
    public bool mousePlayed;
    public bool sharkPlayed;
    public bool keyboardPlayed;

    void Start()
    {
        timer = 10f;
        Cursor.visible = false;

        gameLoop = 0;
        gameLives = 3;
    }

    void Update()
    {
        if (gameStart)

        timer -= Time.deltaTime;

        // STAR WIN
        if (starWin)
        {
            starPlayed = true;
            pointScored++;

            LoadRandomScene();
        }

        // CALENDAR WIN
        else if (calendarWin)
        {
            calendarPlayed = true;
            pointScored++;

            LoadRandomScene();
        }

        // MOUSE WIN
        else if (mouseWin)
        {
            mousePlayed = true;
            pointScored++;

            LoadRandomScene();
        }

        // DOG WIN
        else if (dogWin)
        {
            dogPlayed = true;
            pointScored++;

            LoadRandomScene();
        }

        // Shark WIN
        else if (sharkWin)
        {
            sharkPlayed = true;
            pointScored++;

            LoadRandomScene();
        }

        //KEYBOARD WIN
        else if (keyboardWin)
        {
            keyboardPlayed = true;
            pointScored++;

            LoadRandomScene();
        }

    }

    void LoadRandomScene()
    {
        List<string> availableScenes = new List<string>();

        // Only add scenes that haven't been played
        if (!dogPlayed)
            availableScenes.Add("Dog");

        if (!calendarPlayed)
            availableScenes.Add("Calendar");

        if (!starPlayed)
            availableScenes.Add("Stars");

        if (!mousePlayed)
            availableScenes.Add("Mouse");

        if (!sharkPlayed)
            availableScenes.Add("Shark");

        if (!keyboardPlayed)
        {
            availableScenes.Add("Keyboard");
        }

            // If all scenes have been played
            if (availableScenes.Count == 0)
        {
            SceneManager.LoadScene("Score");
            return;
        }

        // Pick a random scene from remaining options
        int randomIndex = Random.Range(0, availableScenes.Count + 1);

        SceneManager.LoadScene(availableScenes[randomIndex]);
        timer = 10f;
    }
}