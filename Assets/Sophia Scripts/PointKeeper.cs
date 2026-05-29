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
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        refToGM = GameObject.FindGameObjectWithTag("GM");

        if (livesLeft == 0)
        {
            SceneManager.LoadScene(scoreLevel);
            finalScore = GameObject.Find("ScoreText").GetComponent<TMP_Text>();
            finalScore.text = "" + score;
        }
    }
}
