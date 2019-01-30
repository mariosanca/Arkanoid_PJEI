using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControllerInGame : MonoBehaviour
{

    public int vida = 3;
  

    public Text textoVida;

    public GameObject bola;

    public Animator anim_pausa;

    public Transform origen;

    
    void Start()
    {
        anim_pausa.SetBool("activar",false);
        textoVida.text = "3";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pausa()
    {
        anim_pausa.SetBool("activar", true);
        Time.timeScale = 0f;
    }

    public void VolverMenu()
    {
        SceneManager.LoadScene(sceneName: "Menu");
        Time.timeScale = 1f;
    }

    public void Play()
    {
        anim_pausa.SetBool("activar", false);
        Time.timeScale = 1f;
    }

    public void ReiniciarNivel()
    {
        anim_pausa.SetBool("activar", false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }


    void Instancion()
    {
        Instantiate(bola, origen.position, bola.transform.rotation);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bola")&& vida>=0)
        {
            vida--;
            textoVida.text = vida.ToString();
            Destroy(collision.gameObject);


            Invoke("Instancion", 2);
        }
        if (collision.gameObject.CompareTag("bola") && vida ==0)
        {
            Invoke("ReiniciarNivel",2);
        }
        
    }

   
}
