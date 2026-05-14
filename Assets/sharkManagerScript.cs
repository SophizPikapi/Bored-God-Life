using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sharkManagerScript : MonoBehaviour
{
    public Color good = Color.white;
    public Color bad = Color.yellow;
    public int totalTeeth;
    public int collectedTeeth;
    public GameObject winScreen;
    public GameObject loseScreen;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (totalTeeth == collectedTeeth && totalTeeth != 0)
        {
            Debug.Log("You Win!");
            winScreen.transform.position = new Vector2 (0, 0);
        }
    }
}
