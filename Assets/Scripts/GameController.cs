using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController: MonoBehaviour
{

    public Animator animMenuPrincipal;
    public Animator animMenuSeleccion;
    public Animator animInfo;
    public Animator mutear;

    public AudioSource audioMenu;


    bool estaMuted = false;

    // Start is called before the first frame update
    void Start()
    {
        animMenuSeleccion.SetBool("activar",false);
        animMenuPrincipal.SetBool("desActivar", false);
        animInfo.SetBool("activar", false);
        
        audioMenu = GetComponent<AudioSource>();
        audioMenu.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NoMuestraMenu()
    {
        animMenuPrincipal.SetBool("desActivar",true);
    }
    public void MuestraMenu()
    {
        animMenuPrincipal.SetBool("desActivar", false);
        animInfo.SetBool("activar", false);
        animMenuSeleccion.SetBool("activar", false);
    }


    public void MuestraInfo()
    {
        animInfo.SetBool("activar",true);
        animMenuPrincipal.SetBool("desActivar", false);

    }

    public void MuestraMenuSeleccion()
    {
        animMenuSeleccion.SetBool("activar", true);
    }

    public void LvlFacil()
    {
        SceneManager.LoadScene(sceneName: "lvlFACIL");
    }
    public void LvlMedio()
    {
        SceneManager.LoadScene(sceneName: "lvlMEDIO");
    }
    public void LvlDificil()
    {
        SceneManager.LoadScene(sceneName: "lvlDIFICIL");
    }

    public void Mutear()
    {

        estaMuted = !estaMuted;

        audioMenu.mute = estaMuted;
        mutear.SetBool("mutear", estaMuted);

    }

}
