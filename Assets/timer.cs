using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour
{
    public string sceneName;
    public Scene currentScene;

    public bool timerOn;
    public bool gameWon;
    public float tickTimer;
    public float fullTickTimer = 5;
    public GameManager refToGM;

    public GameObject timer1;
    public GameObject timer2;
    public GameObject timer3;
    public GameObject timer4;

    public SpriteRenderer timer1Renderer;
    public SpriteRenderer timer2Renderer;
    public SpriteRenderer timer3Renderer;
    public SpriteRenderer timer4Renderer;

    public Color on;
    public Color off;
    
    // Start is called before the first frame update
    void Start()
    {
        tickTimer = 5;
        timer1 = GameObject.FindGameObjectWithTag("Time1");
        timer2 = GameObject.FindGameObjectWithTag("Time2");
        timer3 = GameObject.FindGameObjectWithTag("Time3");
        timer4 = GameObject.FindGameObjectWithTag("Time4");

        timer1Renderer = timer1.GetComponent<SpriteRenderer>();
        timer2Renderer = timer2.GetComponent<SpriteRenderer>();
        timer3Renderer = timer3.GetComponent<SpriteRenderer>();
        timer4Renderer = timer4.GetComponent<SpriteRenderer>();


    }

    // Update is called once per frame
    void Update()
    {
        currentScene = SceneManager.GetActiveScene();
        sceneName = currentScene.name;

        if (sceneName != "transition" || sceneName != "Menu")
        {
            refToGM.gameStart = true;

            if (gameWon)
            {
                timerOn = false;
            }

            if (!gameWon)
            {
                timerOn = true;
            }
        }


        if (timerOn == true )
        {
            tickTimer -= Time.deltaTime;

            //win while timer ongoing
            if (tickTimer > 0.01f)
            {
                if (sceneName == "Shark")
                {
                    if (refToGM.sharkWin == true)
                    {
                        gameWon = true;
                    }
                }

                if (sceneName == "Dog")
                {
                    if (refToGM.dogWin == true)
                    {
                        gameWon = true;
                    }
                }

                if (sceneName == "Calendar")
                {
                    if (refToGM.calendarWin == true)
                    {
                        gameWon = true;
                    }
                }

                if (sceneName == "Stars")
                {
                    if (refToGM.starWin == true)
                    {
                        gameWon = true;
                    }
                }

                if (sceneName == "Mouse")
                {
                    if (refToGM.mouseWin == true)
                    {
                        gameWon = true;
                    }
                }

                if (sceneName == "Keyboard")
                {
                    if (refToGM.keyboardWin == true)
                    {
                        gameWon = true;
                    }
                }
            }

            // timer runs out
            if (tickTimer <= 0.01)
            {
                timerOn = false;

                if (sceneName == "Shark")
                {
                    if (refToGM.sharkWin != true)
                    {
                        refToGM.sharkLose = true;
                    }
                }

                if (sceneName == "Dog")
                {
                    if (refToGM.dogWin != true)
                    {                                       
                        refToGM.dogLose = true;
                    }
                }

                if (sceneName == "Calendar")
                {
                    if (refToGM.calendarWin != true)
                    {                                       
                        refToGM.calendarLose = true;
                    }
                }

                if (sceneName == "Stars")
                {
                    if (refToGM.starWin != true)
                    {                                       
                        refToGM.starLose = true;
                    }
                }

                if (sceneName == "Mouse")
                {
                    if (refToGM.mouseWin != true)
                    {                                       
                        refToGM.mouseLose = true;
                    }
                }

                if (sceneName == "Keyboard")
                {
                    if (refToGM.keyboardWin != true)
                    {           
                        refToGM.keyboardLose = true;
                    }
                }



            }
        }
        if (!timerOn)
        {
            tickTimer = 5;
        }

        if (tickTimer <= fullTickTimer * 0.75f)
        {
            timer1Renderer.color = off;
            timer2Renderer.color = on;
            timer3Renderer.color = on;
            timer4Renderer.color = on;
        }
        if (tickTimer <= fullTickTimer * 0.5f)
        {
            timer1Renderer.color = off;
            timer2Renderer.color = off;
            timer3Renderer.color = on;
            timer4Renderer.color = on;
        }
        if (tickTimer <= fullTickTimer * 0.25f)
        {
            timer1Renderer.color = off;
            timer2Renderer.color = off;
            timer3Renderer.color = off;
            timer4Renderer.color = on;
        }
        if (tickTimer <= fullTickTimer * 0f)
        {
            timer1Renderer.color = off;
            timer2Renderer.color = off;
            timer3Renderer.color = off;
            timer4Renderer.color = off;
        }

    }
}
