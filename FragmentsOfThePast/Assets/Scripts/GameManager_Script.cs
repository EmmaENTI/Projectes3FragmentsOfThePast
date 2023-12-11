using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager_Script : MonoBehaviour
{
    //Total de Espiritus
   [SerializeField] int totalSpiritsAmount;

    //Contador de dias
    public int dayCounter;

    //Lista con todos los espiritus
    [SerializeField] GameObject spiritList;

    //Spirit Info Script
    public Spirit_Info_Script spirit_Info_Script;

    //Spirit Number
    public int spiritNumber;

    //Imagen del espiritu Big
    [SerializeField] Image bigImage;

    //Tetx Panel
    [SerializeField] GameObject textPanel;

    //Panel de consulta
    [SerializeField] GameObject consultaPanel;

    //First Iteraciton Bool para comenzar conversacion
    [SerializeField] bool firstInteraction;


    //Player's Name
    public string playerName;

    private void Start()
    {
        //Desactivar el panel de texto y la imagen del espiritu
        bigImage.enabled = false;
        //textPanel.SetActive(false);
        playerName = PlayerPrefs.GetString("Player Name");
    }


    //Al seleccionar un espiritu en la calle
    public void SpiritSelectedFunction()
    {
        //Recibe el spirit info script del espiritu sleeccionado
        spirit_Info_Script = spiritList.transform.GetChild(spiritNumber).GetComponent<Spirit_Info_Script>();

        //Pon la imagen del espitiu seleccionado
        bigImage.sprite = spirit_Info_Script.bigImageSprite;

        //Activa la imagen
        bigImage.enabled = true;
    }
}
