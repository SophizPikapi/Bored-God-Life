using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public Color hover;
    public Color touch;
    public Color unTouched;
    public SpriteRenderer button;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnMouseEnter()
    {
        button.color = hover;
    }
    public void OnMouseExit()
    {
        button.color = unTouched;
    }
    public void OnMouseDown()
    {
        button.color = touch;
    }
}
