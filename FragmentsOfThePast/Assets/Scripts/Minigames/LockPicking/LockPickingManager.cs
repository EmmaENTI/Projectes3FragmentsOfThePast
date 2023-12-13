using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockPickingManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject lockObject;
    [SerializeField] GameObject skillCheckObject;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToggleView()
    {
        lockObject.SetActive(!lockObject.activeSelf);
        skillCheckObject.SetActive(!skillCheckObject.activeSelf);
    }

    public GameObject GetLockObject()
    {
        return lockObject;
    }

    public GameObject GetSkillCheckObject()
    {
        return skillCheckObject;
    }

    public Lock GetLockComponent()
    {
        return lockObject.GetComponent<Lock>();
    }

    public SkillCheck GetSkillCheckComponent()
    {
        return skillCheckObject.GetComponent<SkillCheck>();
    }
}
