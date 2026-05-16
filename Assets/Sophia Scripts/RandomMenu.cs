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
    public bool delayStart;
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
            if (timerStart)
            {
                timer -= Time.deltaTime;
            }
            if (delayStart)
            {
                delayTimer -= Time.deltaTime;
            }

            if (refToGM.starWin || refToGM.mouseWin || refToGM.calendarWin || refToGM.dogWin)
            {
                pointScored++;
                delayStart = true;
                timerStart = false;
                Debug.Log("You scored a point!");
            }
            else if (timer <= 0)
            {
                refToGM.gameLives--;
                delayStart = true;
                timerStart = false;
                Debug.Log("You lost a life!");
            }

        }
        if (delayTimer <= 0)
        {
            Randomisation();
            delayStart = false;
            timerStart = true;
        }
        
    }
    private void OnMouseDown()
    {
        gameStart = true;

        DontDestroyOnLoad(this.gameObject);
        sceneNum = Random.Range(0, sceneList.Count);
        SceneManager.LoadScene(sceneList[sceneNum]);
        sceneList.RemoveAt(sceneNum);
        timer = 10f;
        timerStart = true;
        delayTimer = 3f;
        delayStart = false;
    }
    public void Randomisation()
    {
        DontDestroyOnLoad(this.gameObject);
        sceneNum = Random.Range(0, sceneList.Count);
        SceneManager.LoadScene(sceneList[sceneNum]);
        sceneList.RemoveAt(sceneNum);
        timer = 10f;
        delayTimer = 3f;
        timerStart = true;
        delayStart = false;

        refToGM.starWin = false;
        refToGM.dogWin = false;
        refToGM.calendarWin = false;
        refToGM.mouseWin = false;
    }
}
