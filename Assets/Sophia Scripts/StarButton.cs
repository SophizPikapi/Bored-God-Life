using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarButton : MonoBehaviour
{
    public Color hover;
    public Color touch;
    public Color unTouched;
    public SpriteRenderer sr;
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
        sr.color = hover;
    }
    public void OnMouseExit()
    {
        sr.color = unTouched;
    }
    public void OnMouseDown()
    {
        sr.color = touch;
    }
}
