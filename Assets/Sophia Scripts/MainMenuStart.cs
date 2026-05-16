using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuStart : MonoBehaviour
{
    public GameManager refToGM;

    private void OnMouseDown()
    {
        refToGM.gameStart = true;

        // Create a list of available scenes
        List<string> availableScenes = new List<string>();

        if (!refToGM.dogPlayed)
            availableScenes.Add("Dog");

        if (!refToGM.calendarPlayed)
            availableScenes.Add("Calendar");

        if (!refToGM.starPlayed)
            availableScenes.Add("Star");

        if (!refToGM.mousePlayed)
            availableScenes.Add("Mouse");

        // Safety check
        if (availableScenes.Count == 0)
        {
            SceneManager.LoadScene("Score");
            return;
        }

        // Pick random scene
        int randomIndex = Random.Range(0, availableScenes.Count + 1);

        SceneManager.LoadScene(availableScenes[randomIndex]);
    }
}