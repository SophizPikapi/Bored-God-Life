using UnityEngine;

public class Dirt : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public float fadeSpeed = 5f; 

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void CleanDirt()
    {

        Color c = spriteRenderer.color;
        c.a -= fadeSpeed * Time.deltaTime;
        spriteRenderer.color = c;

        if (c.a <= 0)
        {
            KeyboardGameManager.Instance.DirtCleaned();
            Destroy(gameObject);
        }
    }
}