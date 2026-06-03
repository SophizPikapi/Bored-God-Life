using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class highScoreUpdater : MonoBehaviour
{
    public TextMeshPro highScoreText;
    public PointKeeper pointRef;
    // Start is called before the first frame update
    void Start()
    {
        highScoreText = this.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        highScoreUpdate();
    }

    public void highScoreUpdate()
    {   
        if (PlayerPrefs.HasKey("SavedHighScore"))
        {
            if (PointKeeper.score > PlayerPrefs.GetInt("SavedHighScore"))
            {
                PlayerPrefs.SetInt("SavedHighScore", PointKeeper.score);
            }
        }

        else
        {
            PlayerPrefs.SetInt("SavedHighScore", PointKeeper.score);
        }

        highScoreText.text = PlayerPrefs.GetInt("SavedHighScore").ToString();
    }
}
