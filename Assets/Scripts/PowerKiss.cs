using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerKiss : MonoBehaviour
{

    public GameObject bola;
    GameObject barra;
    float duracion;

    // Start is called before the first frame update
    void Start()
    {
        barra = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("runa"))
        {

            Pegote();
        }
    }

    void Pegote()
    {
        if (Time.time < duracion)
        {

        }
    }
}
