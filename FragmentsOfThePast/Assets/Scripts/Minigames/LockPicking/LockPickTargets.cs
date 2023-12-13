using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class LockPickTargets : MonoBehaviour
{
    [SerializeField] private Lock lockScript;

    [SerializeField] private GameObject skillCheckObject;

    float timer = 0.0f;
    float timeToSpawnSkillCheck = 2.0f;

    private void Start()
    {
        lockScript = GameObject.Find("Lock").GetComponent<Lock>();
    }

    private void Update()
    {
        if (timer > timeToSpawnSkillCheck)
        {

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "LayerTarget" + lockScript.GetNextLayerNum())
        {
            // Play Sound
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.name == "LayerTarget"+lockScript.GetNextLayerNum())
        {
            StartCoroutine(StartVibrating());

            Destroy(collision.transform.parent.GetChild(collision.transform.GetSiblingIndex()-1).gameObject);
            Destroy(collision.gameObject);
            lockScript.SetNextLayerNum();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.name == "LayerTarget" + lockScript.GetNextLayerNum())
        {
            timer = 0.0f;
        }
    }

    IEnumerator StartVibrating()
    {
        timer += Time.deltaTime;
        Vector3 newRotation = new Vector3(0, 0, Mathf.Sin(Time.time * 20f) * 0.2f);
        transform.Rotate(newRotation);
        yield return null;
    }
    
}
