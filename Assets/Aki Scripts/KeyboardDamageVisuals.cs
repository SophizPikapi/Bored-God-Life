using UnityEngine;

public class KeyboardDamageVisuals : MonoBehaviour
{
    [Header("Components")]
    public SpriteRenderer spriteRenderer;

    // --- THIS IS YOUR NEW REFERENCE SLOT ---
    public KeyboardGameManager refToKBGM;

    [Header("Health Sprites")]
    public Sprite fullHealthSprite;
    public Sprite midHealthSprite;
    public Sprite lowHealthSprite;

    void Start()
    {
        if (spriteRenderer == null)
        {
            spriteRenderer = GetComponent<SpriteRenderer>();
        }

        if (spriteRenderer != null && fullHealthSprite != null)
        {
            spriteRenderer.sprite = fullHealthSprite;
        }
    }

    public void UpdateDamageSprite()
    {
        Debug.Log("🚨 The GameManager successfully poked the Visuals script!");

        if (spriteRenderer == null)
        {
            Debug.LogError("❌ BUT the SpriteRenderer is missing, so I am cancelling!");
            return;
        }

        // --- CHECKING FOR THE REFERENCE ---
        if (refToKBGM == null)
        {
            Debug.LogError("❌ You forgot to drag the GameManager into the refToKBGM slot!");
            return;
        }

        // --- USING YOUR NEW REFERENCE HERE ---
        int currentScratches = refToKBGM.scratchesMade;

        Debug.Log($"🎨 VISUALS SCRIPT FIRED! It sees {currentScratches} scratches.");

        if (currentScratches == 0)
        {
            spriteRenderer.sprite = fullHealthSprite;
        }
        else if (currentScratches == 1 || currentScratches == 2)
        {
            spriteRenderer.sprite = midHealthSprite;
        }
        else if (currentScratches >= 3)
        {
            spriteRenderer.sprite = lowHealthSprite;
        }
    }
}