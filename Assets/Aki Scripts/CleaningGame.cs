using UnityEngine;

public class CleaningGame : MonoBehaviour
{
    public Transform handCursor;
    public float safeWipeSpeed = 15f;      // Max speed before damage
    public float minWipeSpeed = 0.5f;      // Min speed to clean (Changed this!)
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

        if (Input.GetMouseButtonDown(0))
        {
            lastMousePos = currentMousePos;
            Debug.Log("🖱️ Click Started!");
        }
        else if (Input.GetMouseButton(0))
        {
            float speed = Vector2.Distance(currentMousePos, lastMousePos) / Time.deltaTime;

            // LOG 1: Check the actual speed numbers
            Debug.Log($"Speed: {speed}");

            if (speed > safeWipeSpeed)
            {
                Debug.Log("⚠️ TOO FAST! Attempting to scratch...");
                if (Time.time > lastScratchTime + scratchCooldown)
                {
                    Instantiate(scratchMaskPrefab, currentMousePos, Quaternion.identity);
                    lastScratchTime = Time.time;
                }
            }
            
            else if (speed > minWipeSpeed) 
            {
                Debug.Log("✅ Safe speed. Scanning for dirt..."); 

                // CHANGED THIS LINE: OverlapPointAll is much more reliable for 2D mouse clicks
                Collider2D[] hits = Physics2D.OverlapPointAll(currentMousePos);
                
                foreach (Collider2D hit in hits)
                {
                    if (hit != null && hit.CompareTag("Dirt"))
                    {
                        Dirt dirt = hit.GetComponent<Dirt>();
                        if (dirt != null)
                        {
                            Debug.Log("🧼 CLEANING DIRT!");
                            dirt.CleanDirt();
                        }
                    }
                }
            }
            else
            {
                // LOG 5: Moving too slow
                Debug.Log("🐢 Moving too slow to clean.");
            }

            lastMousePos = currentMousePos;
        }
    }
}