using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerlvlfacil : MonoBehaviour
{
    public Animator anim_pausa;

    
    void Start()
    {
        anim_pausa.SetBool("activar",false);
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
        SceneManager.LoadScene(sceneName: "lvlFACIL ");
    }
}
