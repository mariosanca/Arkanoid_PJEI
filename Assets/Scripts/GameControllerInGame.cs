using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameControllerInGame : MonoBehaviour
{

    public int vida = 3;
    public bool estaMuted = false;

    public AudioSource altavoz;

    public Text textoVida;
    public Text textoTiempo;

    public GameObject bola;

    public Animator anim_pausa;
    public Animator mutear;
    public Animator win;

    public Transform origen;

    float Timer = 0;

    
    void Start()
    {
        Invoke("Instancion", 2);
        anim_pausa.SetBool("activar",false);
        
        textoVida.text = "3";


    }

    // Update is called once per frame
    public void Update()
    {
        Timer += Time.deltaTime;
        textoTiempo.text = Timer.ToString();

        if (GameObject.FindGameObjectsWithTag("espiritu").Length == 0)
        {
            win.SetTrigger("activar");
            Invoke("Irmenu",3);
            
        }
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


    //Funcion para quitar volumen y activarlo ingame
    public void Mutear()
    {

        estaMuted = !estaMuted;

        altavoz.mute = estaMuted;
        mutear.SetBool("mutear", estaMuted);
           
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

    void Irmenu()
    {
        SceneManager.LoadScene(sceneName: "Menu");
    }

    public void SumaVida()
    {
        vida++;
    }
   
}
