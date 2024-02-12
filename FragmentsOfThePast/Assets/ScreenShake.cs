using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScreenShake : MonoBehaviour
{
    // Duraci�n del efecto de shake en segundos
    public float shakeDuration = 1f;

    // Fuerza del efecto de shake
    public float shakeMagnitude = 0.7f;

    // Velocidad del efecto de shake
    public float shakeSpeed = 1.0f;

    // Posici�n original de la c�mara
    private Vector3 originalPosition;

    void Awake()
    {
        if (GetComponent<Image>() != null)
        {
            originalPosition = transform.localPosition;
        }
    }

    public void Shake()
    {
        StartCoroutine(DoShake());
    }

    IEnumerator DoShake()
    {
        float elapsed = 0.0f;

        while (elapsed < shakeDuration)
        {
            // Calcula la posici�n del shake
            float x = originalPosition.x + Random.Range(-1f, 1f) * shakeMagnitude;
            float y = originalPosition.y + Random.Range(-1f, 1f) * shakeMagnitude;

            // Actualiza la posici�n de la c�mara
            transform.localPosition = new Vector3(x, y, originalPosition.z);

            elapsed += Time.deltaTime * shakeSpeed;


            Debug.Log("SHAKING");

            yield return null;
        }

        // Restablece la posici�n original de la c�mara
        transform.localPosition = originalPosition;
    }
}