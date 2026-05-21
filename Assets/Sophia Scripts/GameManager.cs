using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public scoreKeeperScript refToScore;
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
    public GameObject refToScoreKeeper;
    public int scoreGM;
    public PointKeeper pointRef;

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
            PointKeeper.score++;
            LoadRandomScene();
        }

        // CALENDAR WIN
        else if (calendarWin)
        {
            calendarPlayed = true;
            PointKeeper.score++;
            LoadRandomScene();
        }

        // MOUSE WIN
        else if (mouseWin)
        {
            mousePlayed = true;
            PointKeeper.score++;
            LoadRandomScene();
        }

        // DOG WIN
        else if (dogWin)
        {
            dogPlayed = true;
            PointKeeper.score++;
            LoadRandomScene();
        }

        // SHARK WIN
        else if (sharkWin)
        {
            sharkPlayed = true;
            PointKeeper.score++;
            LoadRandomScene();
        }

        //KEYBOARD WIN
        else if (keyboardWin)
        {
            keyboardPlayed = true;
            PointKeeper.score++;
            LoadRandomScene();
        }




        // STAR LOSE
        if (starLose)
        {
            starPlayed = true;
            PointKeeper.livesLeft -= 1;

            LoadRandomScene();
        }

        // CALENDAR LOSE
        else if (calendarLose)
        {
            calendarPlayed = true;
            PointKeeper.livesLeft -= 1;

            LoadRandomScene();
        }

        // MOUSE LOSE
        else if (mouseLose)
        {
            mousePlayed = true;
            PointKeeper.livesLeft -= 1;

            LoadRandomScene();
        }

        // DOG LOSE
        else if (dogLose)
        {
            dogPlayed = true;
            PointKeeper.livesLeft -= 1;

            LoadRandomScene();
        }

        // SHARK LOSE
        else if (sharkLose)
        {
            sharkPlayed = true;
            PointKeeper.livesLeft -= 1;

            LoadRandomScene();
        }

        //KEYBOARD LOSE
        else if (keyboardLose)
        {
            keyboardPlayed = true;
            PointKeeper.livesLeft -= 1;

            LoadRandomScene();
            Debug.LogError("Score: " + PointKeeper.score);
            Debug.LogError("Live's left: " + PointKeeper.livesLeft);
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