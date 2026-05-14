using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class draggable : MonoBehaviour
{
    Vector3 mousePositionOffset;
    public GameObject sharkManager;

    private Vector3 getMouseWorldPosition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseDown()
    {
        if (this.tag == "badTooth")
        {
            mousePositionOffset = gameObject.transform.position - getMouseWorldPosition();
            gameObject.layer = 10;
        }

        if (this.tag == "Teeth")
        {
            Debug.Log("game over!");
            sharkManager.GetComponent<sharkManagerScript>().loseScreen.transform.position = new Vector2(0, 0);
        }
    }

    private void OnMouseDrag()
    {
        if (this.tag == "badTooth")
        {
            transform.position = getMouseWorldPosition() + mousePositionOffset;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
