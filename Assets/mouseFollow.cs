using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseFollow : MonoBehaviour
{
    // Start is called before the first frame update#
    public Sprite unclicked;
    public Sprite clicked;
    public SpriteRenderer mouse;
    public SpriteRenderer shootingIcon;
    public GameObject winScreen;
    public GameObject loseScreen;
    public Sprite targeted;
    public Sprite aiming;
    private bool isDog;
    public bool currentlyTargeting;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0, 0, 20));
        Cursor.visible = false;

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            mouse.sprite = clicked;
            if (isDog == true)
            {
                Debug.Log("you win!");
                winScreen.transform.position = new Vector2(0,0);
            }
            else
            {
                Debug.Log("game Over!");
                loseScreen.transform.position = new Vector2(0,0);
            }
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            mouse.sprite = unclicked;
        }

        if (!currentlyTargeting)
        {
            shootingIcon.sprite = aiming;
        }

        if (currentlyTargeting)
        {
            shootingIcon.sprite = targeted;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shootable")
        {
            currentlyTargeting = true;
        }

        if (collision.gameObject.tag == "glassDog")
        {
            currentlyTargeting = true;
            isDog = true;
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shootable" || collision.gameObject.tag == "glassDog")
        {
            currentlyTargeting = false;
            isDog = false;
        }
    }


}
