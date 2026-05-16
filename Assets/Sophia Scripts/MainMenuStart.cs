using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuStart : MonoBehaviour
{
    public GameManager refToGM;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown()
    {
        refToGM.gameStart = true;
        refToGM.gameNum = Random.Range(0, 4);

        if (refToGM.gameNum == 0)
        {
            SceneManager.LoadScene("Stars");
        }
        if (refToGM.gameNum == 1)
        {
            SceneManager.LoadScene("Dog");
        }
        if (refToGM.gameNum == 2)
        {
            SceneManager.LoadScene("Calendar");
        }
        if (refToGM.gameNum == 3)
        {
            SceneManager.LoadScene("Mouse");
        }
    }
}
