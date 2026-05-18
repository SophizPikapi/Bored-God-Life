using UnityEngine;

public class CleaningGame : MonoBehaviour
{
    [Header("Cursor Settings")]
    public Transform handCursor;

    [Header("Visuals (Sprites)")]
    public SpriteRenderer cursorSpriteRenderer; 
    public Sprite idleSprite;                   
    public Sprite perfectSprite;                
    public Sprite tooFastSprite;            
    public Sprite tooSoftSprite;

    [Header("Game Settings")]
    public float safeWipeSpeed = 15f;
    public float minWipeSpeed = 1.5f;
    public GameObject scratchMaskPrefab;
    public float scratchCooldown = 0.2f;

    private Vector2 lastMousePos;
    private float lastScratchTime;

    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        Vector2 currentMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (handCursor != null)
        {
            handCursor.position = currentMousePos;
        }

        if (!Input.GetMouseButton(0))
        {
            if (cursorSpriteRenderer != null && idleSprite != null)
            {
                cursorSpriteRenderer.sprite = idleSprite;
            }
        }


        if (Input.GetMouseButtonDown(0))
        {
            lastMousePos = currentMousePos;
        }
        else if (Input.GetMouseButton(0))
        {
            float speed = Vector2.Distance(currentMousePos, lastMousePos) / Time.deltaTime;


            if (cursorSpriteRenderer != null)
            {
                if (speed > safeWipeSpeed)
                {
                    cursorSpriteRenderer.sprite = tooFastSprite; 
                }
                else if (speed > minWipeSpeed)
                {
                    cursorSpriteRenderer.sprite = perfectSprite; 
                }
                else
                {
                    cursorSpriteRenderer.sprite = tooSoftSprite; 
                }
            }


            if (speed > safeWipeSpeed)
            {
                if (Time.time > lastScratchTime + scratchCooldown)
                {
                    Instantiate(scratchMaskPrefab, currentMousePos, Quaternion.identity);
                    lastScratchTime = Time.time;

                    if (KeyboardGameManager.Instance != null)
                    {
                        KeyboardGameManager.Instance.AddScratch();
                    }
                }
            }
            else if (speed > minWipeSpeed)
            {
                Collider2D[] hits = Physics2D.OverlapPointAll(currentMousePos);

                foreach (Collider2D hit in hits)
                {
                    if (hit != null && hit.CompareTag("Dirt"))
                    {
                        Dirt dirt = hit.GetComponent<Dirt>();
                        if (dirt != null)
                        {
                            dirt.CleanDirt();
                        }
                    }
                }
            }

            lastMousePos = currentMousePos;
        }
    }
}