using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class LockPickTargets : MonoBehaviour
{
    Lock lockScript;

    SkillCheck skillCheckScript;

    GameObject lockObject;
    GameObject skillCheckObject;

    [SerializeField] LockPickingManager lockPickingManager;

    float timer = 0.0f;
    float timeToSpawnSkillCheck = 2.0f;

    private void Start()
    {
        lockPickingManager = GameObject.FindGameObjectWithTag("LockPickingManager").GetComponent<LockPickingManager>();
        Debug.Log(lockPickingManager.name);
        
        lockObject = lockPickingManager.GetLockObject();
        skillCheckObject = lockPickingManager.GetSkillCheckObject();


        lockScript = lockPickingManager.GetLockComponent();
        skillCheckScript = lockPickingManager.GetSkillCheckComponent();
    }

    private void Update()
    {
        if (timer > timeToSpawnSkillCheck)
        {
            Destroy(lockPickingManager.GetLockObject().transform.GetChild(0).gameObject);
            Destroy(lockObject.transform.GetChild(1).gameObject);

            skillCheckScript.CreateSkillCheck();
            lockPickingManager.ToggleView();
            lockScript.SetNextLayerNum();

            timer = 0.0f;
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
