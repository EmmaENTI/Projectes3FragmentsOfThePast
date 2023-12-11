using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;
    [SerializeField] private AudioSource _audioSource;

    public void playEffect()
    {
        SoundManager.Instance.PlayEffect(_clip);
    }

    public void playMusic()
    {
        SoundManager.Instance.PlayMusic(_audioSource);
    }


}
