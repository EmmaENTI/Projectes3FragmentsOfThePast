using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterDropLifeSpan : MonoBehaviour
{
    float timerToStart = 0;
    float startTime = 0;
    bool startTimer = false;
    

    // Update is called once per frame
    void Update()
    {
        if (!startTimer) { return; }
        Debug.Log("Starting?");

        timerToStart += Time.deltaTime;

        if (startTime < timerToStart)
        {
            Debug.Log("Dropping");
            transform.position += Vector3.down * Time.deltaTime*1500.0f;
        }
        else if (timerToStart > 10.0f)
        {
            Destroy(gameObject);
        }
    }

    public void SetStartTime(float value)
    {
        startTime = value;

        gameObject.SetActive(true);
    }

    public void StartCounting()
    {
        if (startTimer == false)
        {
            Vector3 photoPos = GameObject.Find("Photo").transform.position;

            startTimer = true;

            if (transform.name == "WaterDrop1")
            {
                transform.position = photoPos + new Vector3(30,0,0);
            }
            else if (transform.name == "WaterDrop2")
            {
                transform.position = photoPos + new Vector3(0,0,0);
            }
            else if (transform.name == "WaterDrop3")
            {
                transform.position = photoPos + new Vector3(-30,0,0);
            }
        }
       

    }
}
