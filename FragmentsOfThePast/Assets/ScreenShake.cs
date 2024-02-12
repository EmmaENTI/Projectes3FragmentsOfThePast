using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScreenShake : MonoBehaviour
{
    // Duración del efecto de shake en segundos
    public float shakeDuration = 1f;

    // Fuerza del efecto de shake
    public float shakeMagnitude = 0.7f;

    // Velocidad del efecto de shake
    public float shakeSpeed = 1.0f;

    // Posición original de la cámara
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
            // Calcula la posición del shake
            float x = originalPosition.x + Random.Range(-1f, 1f) * shakeMagnitude;
            float y = originalPosition.y + Random.Range(-1f, 1f) * shakeMagnitude;

            // Actualiza la posición de la cámara
            transform.localPosition = new Vector3(x, y, originalPosition.z);

            elapsed += Time.deltaTime * shakeSpeed;


            Debug.Log("SHAKING");

            yield return null;
        }

        // Restablece la posición original de la cámara
        transform.localPosition = originalPosition;
    }
}