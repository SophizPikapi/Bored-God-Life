using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toothGoodBad : MonoBehaviour
{
    public Color good = Color.white;
    public Color bad = Color.yellow;
    public int isGood;
    public GameObject refToSharkManager;
    public bool teethSelected;
    // Start is called before the first frame update
    void Start()
    {

        isGood = Random.Range(0, 2);
    }

    // Update is called once per frame
    void Update()
    {

        if (isGood == 0)
        {
            this.GetComponent<SpriteRenderer>().color = good;
        }

        if (isGood == 1)
        {
            this.GetComponent<SpriteRenderer>().color = bad;

            if (teethSelected == false)
            {
                this.tag = "badTooth";
                refToSharkManager.GetComponent<sharkManagerScript>().totalTeeth += 1;
                teethSelected = true;
            }
        }

    }
}
