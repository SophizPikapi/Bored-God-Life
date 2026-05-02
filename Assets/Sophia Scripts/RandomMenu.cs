using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomMenu : MonoBehaviour
{
    public GameManager refToGM;
    public int gameRand;
    public float timer = 10f;
    public bool gameStart = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (gameStart)
        {
            timer -= Time.deltaTime;
            //Dog Script


            //Calendar Script


            //Stars Script
            if (timer <= 0 || refToGM.starWin)
            {
                gameRand = Random.Range(0, 4);
                timer = 10f;
                if (gameRand == 0)
                {
                    SceneManager.LoadScene("Dog");
                }
                if (gameRand == 1)
                {
                    SceneManager.LoadScene("Calendar");
                }
                if (gameRand == 2)
                {
                    SceneManager.LoadScene("Stars");
                }
                if (gameRand == 3)
                {
                    SceneManager.LoadScene("Mouse");
                }
            }

            //Mouse Script

        }
    }
    private void OnMouseDown()
    {
        gameRand = Random.Range(0, 4);
        if (gameRand == 0)
        {
            SceneManager.LoadScene("Dog");
        }
        if (gameRand == 1)
        {
            SceneManager.LoadScene("Calendar");
        }
        if (gameRand == 2)
        {
            SceneManager.LoadScene("Stars");
        }
        if (gameRand == 3)
        {
            SceneManager.LoadScene("Mouse");
        }
        gameStart = true;
    }
}
