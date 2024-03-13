using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AudioManagerMiki : MonoBehaviour
{
    [SerializeField] AudioSource[] sfxList;
    [SerializeField] AudioSource[] musicList;

    float lerpTime = 0.0f;
    int currentMusic = -1;


    #region MUSIC FUNCTIONS

    public void PlayMusic(int index, bool restart)
    {
        if (restart || currentMusic != -1) { StopMusic(); }

        currentMusic = index;
        musicList[currentMusic].Play();
    }
    public void StopMusic()
    {
        if (currentMusic == -1) { return; }

        musicList[currentMusic].Stop();
        currentMusic = -1;
    }

    public void PlayMusicDelayed(int index, float delaySeconds)
    {
        if (currentMusic != -1) { StopMusic(); }

        currentMusic = index;
        musicList[currentMusic].PlayDelayed(delaySeconds);
    }

    public void ToggleMusic(int index)
    {
        if (currentMusic == -1) { return; }

        if (musicList[currentMusic].isPlaying)
        {
            StopMusic();
        }
        else
        {
            PlayMusic(index, true);
        }
    }
    public void SetMusicStereoPan( float value)
    {
        if (currentMusic == -1) { return; }

        musicList[currentMusic].panStereo = Mathf.Clamp(value, -1.0f, 1.0f);
    }
    public IEnumerator LerpMusicStereoPan(int index, float value, float maxTime)
    {
        //TODO, NOT WORKING AS INTENDED

        Debug.Log("ENTEREEED MUSIC");

        while (musicList[index].panStereo != value)
        {
            Debug.Log("DOING");
            float currentLerpTime = Mathf.Max(lerpTime, maxTime);
            musicList[index].panStereo = Mathf.Lerp(musicList[index].panStereo, value, currentLerpTime);
            lerpTime = currentLerpTime + Time.deltaTime;
            yield return new WaitForSeconds(Time.deltaTime);
        }

        lerpTime = 0.0f;
        Debug.Log("Finished");

        yield return null;
    }
    public void ResetMusicStereoPan()
    {
        if (currentMusic == -1) { return; }

        musicList[currentMusic].panStereo = 0;
    }
    public void SetMusicVolume(int index, float volume)
    {
        if (currentMusic == -1) { return; }

        musicList[index].volume = Mathf.Clamp(volume, 0.0f, 1.0f);
    }

    #endregion


    #region SFX FUNCTIONS
    public void PlaySFX(int index)
    {
        sfxList[index].Play();
    }
    public void StopSFX(int index)
    {
        sfxList[index].Stop();
    }
    public void SetSFXStereoPan(int index, float value)
    {
        sfxList[index].panStereo = Mathf.Clamp(value, -1.0f, 1.0f);
    }
    public IEnumerator LerpSFXStereoPan(int index, float value, float maxTime)
    {
        //TODO, NOT WORKING AS INTENDED

        Debug.Log("ENTEREEED SFX");

        while (sfxList[index].panStereo != value)
        {
            Debug.Log("DOING");
            float currentLerpTime = Mathf.Max(lerpTime, maxTime);
            sfxList[index].panStereo = Mathf.Lerp(sfxList[index].panStereo, value, currentLerpTime);
            lerpTime = currentLerpTime + Time.deltaTime;
            yield return null;
        }

        lerpTime = 0.0f;

        yield return null;
    }
    public void ResetSFXStereoPan(int index)
    {
        sfxList[index].panStereo = 0;
    }
    public void SetSFXVolume(int index, float volume)
    {
        sfxList[index].volume = Mathf.Clamp(volume, 0.0f, 1.0f);
    }

    #endregion



    
    

    
}
