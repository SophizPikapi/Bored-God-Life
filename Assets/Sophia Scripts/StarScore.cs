using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarScore : MonoBehaviour
{
    public GameManager refToGM;
    public int starScore;
    // Start is called before the first frame update
    void Start()
    {
        starScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (starScore == 9)
        {
            refToGM.starWin = true;
        }
    }
}
