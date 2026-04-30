using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarManager : MonoBehaviour
{
    public GameManager refToGM;
    public GameObject[] starList;
    // Start is called before the first frame update
    void Start()
    {
        if (refToGM.difficultyLevel == 0)
        {
            starList[0].SetActive(true);
        }
        else if (refToGM.difficultyLevel == 1)
        {
            starList[1].SetActive(true);
        }
        else if (refToGM.difficultyLevel == 2)
        {
            starList[2].SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
