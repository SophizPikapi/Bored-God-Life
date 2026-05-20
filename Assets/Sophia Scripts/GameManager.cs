using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager selfRef;
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

    [Header("Lose Conditions")]
    public bool dogLose = false;
    public bool calendarLose = false;
    public bool starLose = false;
    public bool mouseLose = false;
    public bool sharkLose = false;
    public bool keyboardLose = false;

    [Header("Played Conditions")]
    public bool dogPlayed;
    public bool calendarPlayed;
    public bool starPlayed;
    public bool mousePlayed;
    public bool sharkPlayed;
    public bool keyboardPlayed;

    [Header("Score Keeper")]
    GameObject refToScoreKeeper;
    public int scoreGM;

    void Start()
    {
        selfRef = this;
        Cursor.visible = false;

        gameLoop = 0;
        gameLives = 3;
    }

    void Update()
    {
        refToScoreKeeper = GameObject.FindGameObjectWithTag("scoreKeeper");

        if (gameStart)

        // STAR WIN
        if (starWin)
        {
            starPlayed = true;
            
            LoadRandomScene();
        }

        // CALENDAR WIN
        else if (calendarWin)
        {
            calendarPlayed = true;
            scoreGM++;
            LoadRandomScene();
        }

        // MOUSE WIN
        else if (mouseWin)
        {
            mousePlayed = true;
            scoreGM++;
            LoadRandomScene();
        }

        // DOG WIN
        else if (dogWin)
        {
            dogPlayed = true;
            scoreGM++;
            LoadRandomScene();
        }

        // SHARK WIN
        else if (sharkWin)
        {
            sharkPlayed = true;
            scoreGM++;

            LoadRandomScene();
        }

        //KEYBOARD WIN
        else if (keyboardWin)
        {
            keyboardPlayed = true;
            scoreGM++;
            LoadRandomScene();
        }




        // STAR LOSE
        if (starLose)
        {
            starPlayed = true;
            gameLives--;

            LoadRandomScene();
        }

        // CALENDAR LOSE
        else if (calendarLose)
        {
            calendarPlayed = true;
            gameLives--;

            LoadRandomScene();
        }

        // MOUSE LOSE
        else if (mouseLose)
        {
            mousePlayed = true;
            gameLives--;

            LoadRandomScene();
        }

        // DOG LOSE
        else if (dogLose)
        {
            dogPlayed = true;
            gameLives--;

            LoadRandomScene();
        }

        // SHARK LOSE
        else if (sharkLose)
        {
            sharkPlayed = true;
            gameLives--;

            LoadRandomScene();
        }

        //KEYBOARD LOSE
        else if (keyboardLose)
        {
            keyboardPlayed = true;
            gameLives--;

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
    }
}