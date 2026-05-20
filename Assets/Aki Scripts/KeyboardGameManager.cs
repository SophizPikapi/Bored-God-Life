using UnityEngine;

public class KeyboardGameManager : MonoBehaviour
{
    public GameManager refToGM;
    public static KeyboardGameManager Instance;
    public KeyboardDamageVisuals keyboardVisuals;

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

        if (scratchesMade >= 3)
        {
            winCondition = "lose";
            Debug.LogError("GAME OVER! You scratched the keyboard too much. State: " + winCondition);
            refToGM.keyboardLose = true;
        }
        // If this slot is empty (null), the GameManager just quietly gives up and skips it!
        if (keyboardVisuals != null)
        {
            keyboardVisuals.UpdateDamageSprite();
        }
    }


    public void DirtCleaned()
    {
 
        if (winCondition != "playing") return;

        dirtLeft = dirtLeft - 1;
        Debug.Log($"Dirt cleaned! Dirt left: {dirtLeft}");

        if (dirtLeft == 0)
        {
            winCondition = "win";
            Debug.Log("YOU WIN! The keyboard is perfectly clean. State: " + winCondition);
            refToGM.keyboardWin = true;
        }
    }
}