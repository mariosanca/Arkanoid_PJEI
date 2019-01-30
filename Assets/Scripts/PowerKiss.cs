using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerKiss : MonoBehaviour
{

    GameObject barra;
    

    bool activado = false;

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
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("colis");
            GameObject[] bolas = GameObject.FindGameObjectsWithTag("bola");

            for (int i = 0; i < bolas.Length; i++)
            {
                bolas[i].GetComponent<ReboteBola>().ActivPowerKiss();
            }

        }
    }




}
