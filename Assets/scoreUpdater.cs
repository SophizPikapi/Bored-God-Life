using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoreUpdater : MonoBehaviour
{
    public GameObject refToScoreKeeper;
    public TextMeshPro scoreText;
    public PointKeeper pointRef;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = this.GetComponent<TextMeshPro>();
    }

    // Update is called once per frame
    void Update()
    {
        refToScoreKeeper = GameObject.FindGameObjectWithTag("scoreKeeper");

        scoreText.text = ("Score: ") + PointKeeper.score;
    }
}
