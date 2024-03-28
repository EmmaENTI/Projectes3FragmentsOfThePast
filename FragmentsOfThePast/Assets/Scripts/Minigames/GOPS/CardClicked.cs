using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CardClicked : MonoBehaviour, IPointerDownHandler
{
    GOPSManager gopsManager;

    int cardValue = 0;

    public void SetCardValue(int value)
    {
        cardValue = value;
    }

    public void SetManager(GOPSManager manager)
    {
        gopsManager = manager;
    }

    void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
    {
        gopsManager.SetPlayerCardResponse(cardValue);

        // TEMP (TREURE PER FICAR LA ANIMACIO DE LA CARTA)

        Destroy(gameObject);
    }
}
