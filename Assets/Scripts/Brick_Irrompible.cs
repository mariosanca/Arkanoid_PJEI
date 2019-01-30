using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick_Irrompible : MonoBehaviour
{

    public Animator animIrrompible;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animIrrompible.SetTrigger("romper");
    }
}
