using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class r : MonoBehaviour
{
    public float speedy;
    public float vertical;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0, speedy * vertical);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "zombi")
        {
            Destroy(this.gameObject);
        }
    }
}
