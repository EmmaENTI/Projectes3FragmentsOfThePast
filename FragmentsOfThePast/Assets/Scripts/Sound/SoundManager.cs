using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;

    [SerializeField] private AudioSource _musicSource, _effectSource;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }

        else
        {
            DontDestroyOnLoad (gameObject);
        }
    }

    public void PlayEffect(AudioClip clip)
    {
        _effectSource.PlayOneShot(clip);
    }

    public void PlayMusic(AudioSource clip)
    {
        clip.Play();
    }

    public void ChangeMasterVolume(float value)
    {
        AudioListener.volume = value;
    }
}
