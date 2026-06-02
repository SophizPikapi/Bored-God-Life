using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textDisappear : MonoBehaviour
{
    public bool isOn;
    SpriteRenderer spriteRenderer;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        isOn = true;
        spriteRenderer = GetComponent<SpriteRenderer>();
        timer = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            isOn = false;
        }

        if (isOn)
        {
            spriteRenderer.enabled = true;
        }

        if (!isOn)
        {
            spriteRenderer.enabled = false;
        }
    }
}
