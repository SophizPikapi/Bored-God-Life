using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomMenu : MonoBehaviour
{
    public GameManager refToGM;
    public int gameRand;
    public float timer = 10f;
    public float delayTimer = 3f;
    public bool gameStart = false;
    public List<string> sceneList = new List<string>();
    public int sceneNum;
    public int pointScored;
    public bool timerStart;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        

    }

    // Update is called once per frame
    void Update()
    {
        if (gameStart)
        {
            timerStart = true;

            if (refToGM.starWin || refToGM.mouseWin || refToGM.calendarWin || refToGM.dogWin)
            {
                pointScored++;
                delayTimer -= Time.deltaTime;
                timerStart = false;
                Debug.Log("You scored a point!");
            }
            else if (timer <= 0)
            {
                refToGM.gameLives--;
                delayTimer -= Time.deltaTime;
                timerStart = false;
                Debug.Log("You lost a life!");
            }

        }
        if (delayTimer <= 0)
        {
            DontDestroyOnLoad(this.gameObject);
            sceneNum = Random.Range(0, sceneList.Count);
            SceneManager.LoadScene(sceneList[sceneNum]);
            sceneList.RemoveAt(sceneNum);
            timer = 10f;
            timerStart = true;
            delayTimer = 3f;
        }
        if (timerStart)
        {
            timer -= Time.deltaTime;
        }
    }
    private void OnMouseDown()
    {
        //gameRand = Random.Range(0, 4);
        //if (gameRand == 0)
        //{
        //    SceneManager.LoadScene("Dog");
        //}
        //if (gameRand == 1)
        //{
        //    SceneManager.LoadScene("Calendar");
        //}
        //if (gameRand == 2)
        //{
        //    SceneManager.LoadScene("Stars");
        //}
        //if (gameRand == 3)
        //{
        //    SceneManager.LoadScene("Mouse");
        //}
        //gameStart = true;
    }
}
