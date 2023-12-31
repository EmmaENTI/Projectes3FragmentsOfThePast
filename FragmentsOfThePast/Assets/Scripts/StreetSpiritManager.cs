using System.Collections;
using System.Collections.Generic;
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

    [SerializeField] PlaySound playSound;

    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip consultaTheme;

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
 
           luisDay1Phase1Script.canStartDialogue = false;
           luisDay1Phase1Script.canTalk = true;  

    }
}
