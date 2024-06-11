using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathzombi : MonoBehaviour
{
    public float vertical;
    public float speedy;
    public AudioSource AudioSource;
    private Rigidbody2D velocity;
    // Start is called before the first frame update
    private void Awake()
    {
        velocity = GetComponent<Rigidbody2D>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        velocity.velocity = new Vector2(speedy * vertical, 0);
       
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {  
        if (collision.gameObject.tag == "horizontal") 
        {
            vertical = vertical *-1;
        }
        if (collision.gameObject.tag == "bullet")
        {
            Destroy(this.gameObject);
            AudioSource.Play();

        }
    }
}
