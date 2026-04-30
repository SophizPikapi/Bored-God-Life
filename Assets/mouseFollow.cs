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
    public Sprite targeted;
    public Sprite aiming;
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
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Shootable")
        {
            currentlyTargeting = false;
        }
    }


}
