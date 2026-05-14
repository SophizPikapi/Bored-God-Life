using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseGeneric : MonoBehaviour
{
    public Sprite unclicked;
    public Sprite clicked;
    public SpriteRenderer mouse;
    // Start is called before the first frame update
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
    }
}
