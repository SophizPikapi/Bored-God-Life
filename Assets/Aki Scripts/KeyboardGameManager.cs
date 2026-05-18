using UnityEngine;

public class KeyboardGameManager : MonoBehaviour
{
    public static KeyboardGameManager Instance;

    [Header("Game Stats")]
    public int dirtLeft = 8;
    public int scratchesMade = 0;

    [Header("Game State")]
    public string winCondition = "playing";

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScratch()
    {
        if (winCondition != "playing") return;

        scratchesMade++;
        Debug.Log($"Scratch made! Total scratches: {scratchesMade}");

        if (scratchesMade >= 4)
        {
            winCondition = "lose";
            Debug.LogError("GAME OVER! You scratched the keyboard too much. State: " + winCondition);
        }
    }


    public void DirtCleaned()
    {
 
        if (winCondition != "playing") return;

        dirtLeft--;
        Debug.Log($"Dirt cleaned! Dirt left: {dirtLeft}");

        if (dirtLeft <= 0)
        {
            winCondition = "win";
            Debug.Log("YOU WIN! The keyboard is perfectly clean. State: " + winCondition);
        }
    }
}