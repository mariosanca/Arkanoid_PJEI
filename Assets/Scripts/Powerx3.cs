using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerx3 : MonoBehaviour
{

    public GameObject barra;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {

            GameObject[] numeroBolas = GameObject.FindGameObjectsWithTag("bola");
            

            for (int i = 0; i < numeroBolas.Length; i++)
            {
                barra.GetComponent<PlayerMovement>().InstanciaBola();
                barra.GetComponent<PlayerMovement>().InstanciaBola();
                barra.GetComponent<PlayerMovement>().InstanciaBola();
            }

        Destroy(gameObject);
        }
    }
}
