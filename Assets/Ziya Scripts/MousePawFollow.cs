using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePawFollow : MonoBehaviour
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

    }
}