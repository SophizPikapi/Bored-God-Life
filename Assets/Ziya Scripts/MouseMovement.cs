using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MouseMovement : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool Zapped = false;
    public bool GameStart = false;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        float distance = Vector3.Distance(transform.position, pos);


        if (GameStart == true)
        {
            if (Zapped == false)
            {
                if (distance > 0.5f)
                {
                    transform.up = pos - transform.position;
                    rb.velocity = transform.up * speed * Time.deltaTime;
                }
                else
                {
                    rb.velocity = Vector3.zero;
                }
            }
            else
            {
                rb.velocity = Vector3.zero;
            }
            //Debug.Log("IsTriggered");


        }
        else
        {
            if (distance < 0.5f)
            {
                GameStart = true;
            }
        }

    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Electricity"))
        {
            Debug.Log("ZAP");

            Zapped = true;
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            //SceneManager.LoadScene
        }
    }

}
