using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AntiSpamButton : MonoBehaviour
{
    public Button button;
    public float cooldownTime = 1f;

    private void Start()
    {
        if (button == null)
        {
            button = GetComponent<Button>();
        }
    }

    public void OnButtonClick()
    {
        button.interactable = false;

        StartCoroutine(ButtonCooldown());
    }

    private IEnumerator ButtonCooldown()
    {
        yield return new WaitForSeconds(cooldownTime);

        button.interactable = true;
    }
}