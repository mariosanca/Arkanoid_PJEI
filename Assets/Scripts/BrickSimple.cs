using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickSimple : MonoBehaviour {

    public GameObject[] powerUps;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

       
	}

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("bola"))
        {
            Destroy(gameObject);

            int numeAle = Random.Range(0, 25);

            if (numeAle < powerUps.Length)
            {
                Instantiate(powerUps[numeAle], transform.position, transform.rotation);
            }
            
        }
    }
}
