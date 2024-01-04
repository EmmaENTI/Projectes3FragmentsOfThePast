using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainMenuLanguage : MonoBehaviour
{
    private bool canUpdateLanguage;
    private bool EnglishLanguage;
    private bool SpanishLanguage;


    [SerializeField] private TextMeshProUGUI[] texts;


    private void Start()
    {
        EnglishLanguage = true;
        SpanishLanguage = false;
        canUpdateLanguage = true;
    }
    
    private void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            EnglishLanguage = true;
            SpanishLanguage = false;
            canUpdateLanguage = true;
        }

        if (Input.GetKeyDown("2"))
        {
            EnglishLanguage = false;
            SpanishLanguage = true;
            canUpdateLanguage = true;
        }

        if(canUpdateLanguage)
        {
            UpdateLanguage();
            canUpdateLanguage = false;
        }
    }


    void UpdateLanguage()
    {
        if (EnglishLanguage)
        {
            texts[0].text = "Start";
            texts[1].text = "Options";
            texts[2].text = "Credits";
            texts[3].text = "Exit";
            texts[4].text = "Back";
            texts[5].text = "Back";
            texts[6].text = "Accept";
            texts[7].text = "Insert a name";
            texts[8].text = "Name";
        }

        if (SpanishLanguage)
        {
            texts[0].text = "Comenzar";
            texts[1].text = "Opciones";
            texts[2].text = "Créditos";
            texts[3].text = "Salir";
            texts[4].text = "Atrás";
            texts[5].text = "Atrás";
            texts[6].text = "Aceptar";
            texts[7].text = "Escribe un nombre";
            texts[8].text = "Nombre";
        }

 
    }
}
