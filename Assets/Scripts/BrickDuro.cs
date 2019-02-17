using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickDuro : MonoBehaviour
{
    int vida = 3;

    Animator anim;
    public GameObject[] powerUps;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (vida == 2)
        {
            anim.SetTrigger("golpear1");
        }

        if (vida == 1)
        {
            anim.SetTrigger("golpear2");
        }

        if (vida <= 0)
        {
            Destroy(gameObject);
        }


    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("bola") || col.gameObject.CompareTag("bolaPU"))
        {
            vida--;

            

            int numeAle = Random.Range(0, 25);

            if (numeAle < powerUps.Length)
            {
                Instantiate(powerUps[numeAle], transform.position, transform.rotation);
            }
        }


    }
}
