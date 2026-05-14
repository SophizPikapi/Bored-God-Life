using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuStart : MonoBehaviour
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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        gameStart = true;
        sceneNum = Random.Range(0, sceneList.Count);
        SceneManager.LoadScene(sceneList[sceneNum]);
        sceneList.RemoveAt(sceneNum);
        timer = 10f;
        timerStart = true;
        delayTimer = 3f;
    }
}
