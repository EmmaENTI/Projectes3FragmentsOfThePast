using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSkillCheckBar : MonoBehaviour
{

    float speed = 250.0f;
    bool canDestroy = false;

    GameObject lockObject;
    GameObject skillCheckObject;

    //Lock lockScript;
    //SkillCheck skillCheckScript;

    LockPickingManager lockPickingManager;

    void Start()
    {
        lockPickingManager = GameObject.FindGameObjectWithTag("LockPickingManager").GetComponent<LockPickingManager>();

        lockObject = lockPickingManager.GetLockObject();
        skillCheckObject = lockPickingManager.GetSkillCheckObject();

        //lockScript = lockPickingManager.GetLockComponent();
        //skillCheckScript = lockPickingManager.GetSkillCheckComponent();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newRotation = new Vector3(0, 0, -speed * Time.deltaTime);
        transform.Rotate(newRotation);

        if (Input.GetMouseButtonDown(0) && canDestroy)
        {
            // Play Sound
            Destroy(skillCheckObject.transform.GetChild(0).gameObject);
            Destroy(skillCheckObject.transform.GetChild(1).gameObject);
            Destroy(gameObject);

            lockPickingManager.ToggleView();
        }
        else if (Input.GetMouseButtonDown(0) && !canDestroy)
        {
            transform.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SkillCheckTarget"))
        {
            canDestroy = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("SkillCheckTarget"))
        {
            canDestroy = false;
        }
    }
}
