using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReboteBola : MonoBehaviour
{

    Rigidbody2D rb;
    public float speed = 5;

    bool activKiss = false;

    public GameObject barra;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            float factor = HitFactor(col.collider.bounds.size.x, transform.position.x, col.gameObject.transform.position.x);

            Vector2 direction = new Vector2(factor, 1).normalized;

            if (!activKiss)
            {
                rb.velocity = direction * speed;
            }
            else
            {
                rb.velocity = Vector2.zero;
            }
            
        }
    }

    private float HitFactor(float barraSize, float ballPosition, float barraPosition)
    {
        return (ballPosition-barraPosition)/barraSize;
    }

    public void ActivPowerKiss()
    {
        activKiss = true;
        transform.parent = barra.transform;
    }
}
