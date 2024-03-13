using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ZoomInImage : MonoBehaviour
{

    bool startZooming = false;
    float timeToReveal = 2.0f;
    float currentTime = 0.0f;
    float timeToReveal2 = 1.0f;
    float currentTime2 = 0.0f;


    Image image;
    Image characterImage;

    void Start()
    {
        image = GetComponent<Image>();
        characterImage = transform.GetChild(0).GetChild(0).GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (startZooming && transform.localScale.x < 12.5f)
        {
            transform.localScale += new Vector3(3,3,3) * Time.deltaTime;
        }
        else if (transform.localScale.x >= 12.0f)
        {
            transform.GetChild(0).gameObject.SetActive(true);

            if (currentTime > timeToReveal)
            {
                if (currentTime2 > timeToReveal2)
                {
                    return;
                }

                currentTime2 += Time.deltaTime;

                characterImage.color = new Color(characterImage.color.r, characterImage.color.g, characterImage.color.b, currentTime2 / timeToReveal2);

                return;
            }
            currentTime += Time.deltaTime;

            image.color = new Color(image.color.r, image.color.g, image.color.b, 1 - currentTime / timeToReveal);
        }
    }

    public void StartZoomIn()
    {
        startZooming = true;
    }
}
