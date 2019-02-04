using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReboteBola : MonoBehaviour
{

    Rigidbody2D rb;
    public float speed = 5;

    bool activKiss = false;

    bool hacerHijo = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            activKiss = false;
            transform.parent = null;
            hacerHijo = false;

        }
    }

    private void OnCollisionStay2D(Collision2D col)
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



            if (hacerHijo == true)
            {
                GameObject barra = GameObject.FindGameObjectWithTag("Player");
                transform.parent = barra.transform;
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
        hacerHijo = true;

    }

    public void ActivPowerSpeedUp()
    {
        rb.velocity = rb.velocity * 2;
    }

    public void ActivPowerSpeedDown()
    {
        rb.velocity = rb.velocity / 100;
    }


}
