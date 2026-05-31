using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PointKeeper : MonoBehaviour
{
    public static int score = 0;
    public static int livesLeft = 3;
    public GameObject refToGM;
    public static PointKeeper selfRef;
    public string scoreLevel;
    public TMP_Text finalScore;
    public GameObject lifeOne;
    public GameObject lifeTwo;
    public GameObject lifeThree;
    Color thisColorI;
    Color thisColorII;
    Color thisColorIII;
    public string sceneName;
    public Scene currentScene;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;
        refToGM = GameObject.FindGameObjectWithTag("GM");
        lifeOne = GameObject.Find("HeartIcon");
        lifeTwo = GameObject.Find("HeartIcon (1)");
        lifeThree = GameObject.Find("HeartIcon (2)");
        
        thisColorI = lifeOne.GetComponent<SpriteRenderer>().color;
        thisColorII = lifeTwo.GetComponent<SpriteRenderer>().color;
        thisColorIII = lifeThree.GetComponent<SpriteRenderer>().color;
        
        if (sceneName == "Menu")
        {
            livesLeft = 3;
            score = 0;
        }

        if (livesLeft <= 2)
        {
            thisColorIII.a = 0.0f;
            thisColorIII = lifeThree.GetComponent<SpriteRenderer>().color = thisColorIII;
        }
        if (livesLeft <= 1)
        {
            thisColorII.a = 0.0f;
            thisColorII = lifeTwo.GetComponent<SpriteRenderer>().color = thisColorII;
        }
        if (livesLeft <= 0)
        {
            SceneManager.LoadScene(scoreLevel);
            finalScore = GameObject.Find("ScoreText").GetComponent<TMP_Text>();
            finalScore.text = "" + score;
        }
    }
}
