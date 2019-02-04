using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PowerVida : MonoBehaviour
{
   

    public Text textoVida;

    


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
        if (col.gameObject.CompareTag("runa"))
        {
            

            GetComponent<GameControllerInGame>().SumaVida();
            textoVida.text = GetComponent<GameControllerInGame>().vida.ToString();
        }
        Destroy(gameObject);
    }
}
