using UnityEngine;

public class Dirt : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public float fadeSpeed = 5f; // Cranked this up

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    public void CleanDirt()
    {
        // For testing, let's make it drop by a HUGE chunk every frame you touch it
        Color c = spriteRenderer.color;
        c.a -= fadeSpeed * Time.deltaTime;
        spriteRenderer.color = c;

        if (c.a <= 0)
        {
            Destroy(gameObject);
        }
    }
}