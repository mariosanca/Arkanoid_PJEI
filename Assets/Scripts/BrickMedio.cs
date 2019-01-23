using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickMedio : MonoBehaviour
{

    int vida = 2;

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (vida == 1)
        {
            anim.SetTrigger("golpear");
        }

        if (vida <= 0)
        {
            Destroy(gameObject);
        }

        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("bola"))
        {
            vida--;
        }
    }
}
