using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class StreetSpiritManager : MonoBehaviour
{
    //Spirit Number
    public int spiritNumber;

    //Game Manager Script
    [SerializeField] GameManager_Script gameManager_Script;

    //Street Panel
    [SerializeField] GameObject streetPanel;

    //Consulta Panel
    [SerializeField] GameObject consultaPanel;

    [SerializeField] LuisDay1Phase1Script luisDay1Phase1Script;
    [SerializeField] MarinaDay1Phase1Script marinaDay1Phase1Script;
    [SerializeField] BrunoDay1Phase1Script brunoDay1Phase1Script;
    [SerializeField] CarmenDay1Phase1Script carmenDay1Phase1Script;
   
    [SerializeField] LuisAmbitiousDialogue luisAmbitiousDialogue;
    [SerializeField] LuisPerfectionistDialogue luisPerfectionistDialogue;
    [SerializeField] LuisLureDialogue luisLureDialogue;
    [SerializeField] LuisLonerDialogue luisLonerDialogue;

    [SerializeField] CarmenAssertiveDialogue carmenAssertiveDialogue;
    [SerializeField] CarmenMaterialisticDialogue carmenMaterialisticDialogue;
    [SerializeField] CarmenIndependentDialogue carmenIndependentDialogue;
    [SerializeField] CarmenEntrepreneurDialogue carmenEntrepreneurDialogue;

    [SerializeField] BrunoBookwormDialogue brunoBookwormDialouge;
    [SerializeField] BrunoGeniusDialogue brunoGeniusDialogue;
    [SerializeField] BrunoGeekDialogue brunoGeekDialouge;
    [SerializeField] BrunoLoyalDialogue brunoLoyalDialogue;


    [SerializeField] MarinaRomanticDialogue marinaRomanticDialogue;
    [SerializeField] MarinaGoodDialogue marinaGoodDialogue;
    [SerializeField] MarinaActiveDialogue marinaActiveDialogue;
    [SerializeField] MarinaChildishDialogue marinaChildishDialogue;

    [SerializeField] PlaySound playSound;

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip consultaTheme;

    [SerializeField] DialoguesInfoManager dialoguesInfoManager;

    //Funcion de Seleccionar Espiritu en la calle
    public void SelectSpirit()
    {
        //El spiritNumber del game manager = al spirit number del espiritu seleccionado
        gameManager_Script.spiritNumber = spiritNumber;

        //LLamara la funcion SpiritSelectedFunction del game manager
        gameManager_Script.SpiritSelectedFunction();

        //Desactivar el street panel
        streetPanel.SetActive(false);

        //Activar al consulta panel
        consultaPanel.SetActive(true);

        playSound.playEffect();

        audioSource.enabled = false;
        audioSource.clip = consultaTheme;
        audioSource.enabled = true;




        //Marina Day1Phase1
        if (spiritNumber == 1 && dialoguesInfoManager.canStartMarinaActiveDialogue == false &&
            dialoguesInfoManager.canStartMarinaChildishDialogue == false &&
            dialoguesInfoManager.canStartMarinaGoodDialogue == false &&
            dialoguesInfoManager.canStartMarinaRomanticDialogue == false)
        {
            marinaDay1Phase1Script.canStartDialogue = false;
            marinaDay1Phase1Script.canTalk = true;
        }

        //Marina Romantic Dialogue
        else if (spiritNumber == 1 && dialoguesInfoManager.canStartMarinaRomanticDialogue)
        {
            marinaRomanticDialogue.canStartDialogue = false;
            marinaRomanticDialogue.canTalk = true;

            dialoguesInfoManager.canStartMarinaRomanticDialogue = false;
            UnityEngine.Debug.Log("AQUI NO");
        }

        //Marina Good Dialogue
        else if (spiritNumber == 1 && dialoguesInfoManager.canStartMarinaGoodDialogue)
        {
            marinaGoodDialogue.canStartDialogue = false;
            marinaGoodDialogue.canTalk = true;

            dialoguesInfoManager.canStartMarinaGoodDialogue = false;
            UnityEngine.Debug.Log("AQUI SI");
        }

        //Marina Active Dialogue
        else if (spiritNumber == 1 && dialoguesInfoManager.canStartMarinaActiveDialogue)
        {
            marinaActiveDialogue.canStartDialogue = false;
            marinaActiveDialogue.canTalk = true;

            dialoguesInfoManager.canStartMarinaActiveDialogue = false;
        }

        //Marina Childish Dialogue
        else if (spiritNumber == 1 && dialoguesInfoManager.canStartMarinaChildishDialogue)
        {
            marinaChildishDialogue.canStartDialogue = false;
            marinaChildishDialogue.canTalk = true;

            dialoguesInfoManager.canStartMarinaChildishDialogue = false;
        }

        //Luis Day1Phase1
        if (spiritNumber == 2 &&
            dialoguesInfoManager.canStartLuisAmbitiousDialogue == false &&
            dialoguesInfoManager.canStartLuisPerfectionistDialogue == false&&
            dialoguesInfoManager.canStartLuisLureDialogue == false &&
            dialoguesInfoManager.canStartLuisLonerDialogue == false)
        {
            luisDay1Phase1Script.canStartDialogue = false;
            luisDay1Phase1Script.canTalk = true;
        }

        //Luis Ambitious Dialogue
        else if (spiritNumber == 2 && dialoguesInfoManager.canStartLuisAmbitiousDialogue)
        {
            luisAmbitiousDialogue.canStartDialogue = false;
            luisAmbitiousDialogue.canTalk = true;

            dialoguesInfoManager.canStartLuisAmbitiousDialogue = false;
        }

        //Luis Perfectonist Dialogue
        else if (spiritNumber == 2 && dialoguesInfoManager.canStartLuisPerfectionistDialogue)
        {
            luisPerfectionistDialogue.canStartDialogue = false;
            luisPerfectionistDialogue.canTalk = true;

            dialoguesInfoManager.canStartLuisPerfectionistDialogue = false;
        }

        //Luis Lure Dialogue
        else if (spiritNumber == 2 && dialoguesInfoManager.canStartLuisLureDialogue)
        {
            luisLureDialogue.canStartDialogue = false;
            luisLureDialogue.canTalk = true;

            dialoguesInfoManager.canStartLuisLureDialogue = false;
        }


        //Luis Loner Dialogue
        else if (spiritNumber == 2 && dialoguesInfoManager.canStartLuisLonerDialogue)
        {
            luisLonerDialogue.canStartDialogue = false;
            luisLonerDialogue.canTalk = true;

            dialoguesInfoManager.canStartLuisLonerDialogue = false;
        }


        //Bruno Day1Phase1
        if (spiritNumber == 3 && dialoguesInfoManager.canStartBrunoBookwormDialogue == false &&
            dialoguesInfoManager.canStartBrunoGeniusDialogue == false &&
            dialoguesInfoManager.canStartBrunoGeekDialogue == false &&
            dialoguesInfoManager.canStartBrunoLoyalDialogue == false)
        {
            brunoDay1Phase1Script.canStartDialogue = false;
            brunoDay1Phase1Script.canTalk = true;
        }

        //Bruno Bookworm Dialogue
        else if (spiritNumber == 3 && dialoguesInfoManager.canStartBrunoBookwormDialogue)
        {
            brunoBookwormDialouge.canStartDialogue = false;
            brunoBookwormDialouge.canTalk = true;

            dialoguesInfoManager.canStartBrunoBookwormDialogue = false;
        }

        //Bruno Genius Dialogue
        else if (spiritNumber == 3 && dialoguesInfoManager.canStartBrunoGeniusDialogue)
        {
            brunoGeniusDialogue.canStartDialogue = false;
            brunoGeniusDialogue.canTalk = true;

            dialoguesInfoManager.canStartBrunoGeniusDialogue = false;
        }

        //Bruno Geek Dialogue
        else if (spiritNumber == 3 && dialoguesInfoManager.canStartBrunoGeekDialogue)
        {
            brunoGeekDialouge.canStartDialogue = false;
            brunoGeekDialouge.canTalk = true;

            dialoguesInfoManager.canStartBrunoGeekDialogue = false;
        }

        //Bruno Loyal Dialogue
        else if (spiritNumber == 3 && dialoguesInfoManager.canStartBrunoLoyalDialogue)
        {
            brunoLoyalDialogue.canStartDialogue = false;
            brunoLoyalDialogue.canTalk = true;

            dialoguesInfoManager.canStartBrunoLoyalDialogue = false;
        }



        //Carmen Day1Phase1
        if (spiritNumber == 4 &&
            dialoguesInfoManager.canStartCarmenAssertiveDialogue == false &&
            dialoguesInfoManager.canStartCarmenMaterialisticDialogue == false &&
            dialoguesInfoManager.canStartCarmenIndependentDialogue == false &&
            dialoguesInfoManager.canStartCarmenEntrepreneurDialogue == false)
        {
            carmenDay1Phase1Script.canStartDialogue = false;
            carmenDay1Phase1Script.canTalk = true;
        }

        //Carmen Assertive
        else if (spiritNumber == 4 && dialoguesInfoManager.canStartCarmenAssertiveDialogue)
        {
            carmenAssertiveDialogue.canStartDialogue = false;
            carmenAssertiveDialogue.canTalk = true;
        }

        //Carmen Materialistic
        else if (spiritNumber == 4 && dialoguesInfoManager.canStartCarmenMaterialisticDialogue)
        {
            carmenMaterialisticDialogue.canStartDialogue = false;
            carmenMaterialisticDialogue.canTalk = true;
        }

        //Carmen Independent
        else if (spiritNumber == 4 && dialoguesInfoManager.canStartCarmenIndependentDialogue)
        {
            carmenIndependentDialogue.canStartDialogue = false;
            carmenIndependentDialogue.canTalk = true;
        }


        //Carmen Entrepreneur
        else if (spiritNumber == 4 && dialoguesInfoManager.canStartCarmenEntrepreneurDialogue)
        {
            carmenEntrepreneurDialogue.canStartDialogue = false;
            carmenEntrepreneurDialogue.canTalk = true;
        }
    }
}
