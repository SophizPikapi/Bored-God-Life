using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarStatus : MonoBehaviour
{
    public GameManager refToGM;
    public GameObject mouse;
    public GameObject[] starPrefab;

    public List<Transform> spawnpt = new List<Transform>();
    public GameObject starPF;
   


    public bool starLight;
    Color starColor;
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < spawnpt.Count; i--)
        {
            GameObject star = Instantiate(starPF, spawnpt[0].transform.position, transform.rotation);
            star.GetComponent<Stars>().refToGM = refToGM;
            star.GetComponent<Stars>().refToMouse = mouse;
            spawnpt.RemoveAt(0);

        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
