
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectorNivel : MonoBehaviour
{

    public Button[] BotonesNivel;

    public int nextLvl = 0;



    // Start is called before the first frame update
    void Start()
    {
        int lvlUnlock = PlayerPrefs.GetInt("lvlUnlock", 0);

        for (int i = 0; i < BotonesNivel.Length; i++)
        {
            if(i > lvlUnlock)
            {
                BotonesNivel[i].interactable = false;
            }  
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PasarNivel()
    {
        if (nextLvl < 3)
        {
            nextLvl++;
            PlayerPrefs.SetInt("lvlUnlock", nextLvl);
        }
        
    }

    
}
