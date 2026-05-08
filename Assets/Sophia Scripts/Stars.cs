using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stars : MonoBehaviour
{
    public ParticleSystem ps;
    public BoxCollider2D bc;
    public GameManager refToGM;
    public GameObject refToMouse;
    public bool starLight;

    // Start is called before the first frame update
    void Start()
    {
        ps = GameObject.Find("StarParticle").GetComponent<ParticleSystem>();
        starLight = false;
        bc = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetMouseButtonDown(0)) && (this.GetComponent<SpriteRenderer>().bounds.Intersects(refToMouse.GetComponent<CircleCollider2D>().bounds)))
        {
            ps.Play();
            refToGM.starScore++;
            starLight = true;
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        
    }
}
