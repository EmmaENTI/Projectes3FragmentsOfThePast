using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnboardCauldron : MonoBehaviour
{
    Image arrowImage;

    float rotationSpeed = 20.0f;

    bool isOnboarding = false;

    AudioManagerMiki audioManager; //SFX: 3 -> Onboard SFX

    bool toggle = true;

    void Start()
    {
        arrowImage = gameObject.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isOnboarding) { return; }

        RotateArrow();
        PulsateArrow();
    }

    void RotateArrow()
    {
        Vector3 newRotation = transform.rotation.eulerAngles - new Vector3(0, 0, transform.rotation.z + rotationSpeed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(newRotation);
    }

    void PulsateArrow()
    {
        arrowImage.color = new Color(arrowImage.color.r, arrowImage.color.g, arrowImage.color.b, Mathf.Clamp(Mathf.Sin(Time.time)/3.0f, 0.05f, 0.3f));
        if (arrowImage.color.a == 0.3f && toggle)
        {
            audioManager.PlaySFX(3);
            toggle = false;
        }
        else if (arrowImage.color.a < 0.1f && !toggle)
        {
            toggle = true;
        }
    }

    public void ActivateOnboarding(bool value)
    {
        isOnboarding = value;
    }

    public void DeactivateOnboarding()
    {
        gameObject.SetActive(false);
    }

    public void SetAudioManager(AudioManagerMiki am)
    {
        audioManager = am;
    }
}
