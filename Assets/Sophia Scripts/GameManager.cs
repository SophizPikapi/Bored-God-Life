using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager selfRef;
    public int starScore;
    public int timer;
    public int difficultyLevel;
    public int gameLoop;
    public int gameNum;
    public int gameLives;
    public enum AllPlayState { Menu, Meteor, Dog, Dragon, Cheese, Star, Shark, Score };
    public AllPlayState currentPlayState;
    public List<Transform> randomGame = new List<Transform>();

    [Header("Win Conditions")]
    public bool dogWin = false;
    public bool calendarWin = false;
    public bool starWin = false;
    public bool mouseWin = false;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        Cursor.visible = false;
        gameLoop = 0;
        gameNum = 0;
        starScore = 0;
        gameLives = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (difficultyLevel == 0)
        {
            if (starScore == 9)
            {
                Debug.Log("You win!");
                starWin = true;
            }
        }
        //else if (difficultyLevel == 1)
        //{
        //    if (starScore == 11)
        //    {
        //        Debug.Log("You win!");
        //        starWin = true;
        //    }
        //}
        //else if (difficultyLevel == 2)
        //{
        //    if (starScore == 13)
        //    {
        //        Debug.Log("You win!");
        //        starWin = true;
        //    }
        //}
    }
}
