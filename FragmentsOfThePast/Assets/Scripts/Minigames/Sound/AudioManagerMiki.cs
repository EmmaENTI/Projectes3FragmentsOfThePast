using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerMiki : MonoBehaviour
{
    [SerializeField] AudioSource[] sfxList;
    [SerializeField] AudioSource[] musicList;

    float lerpTime = 0.0f;


    #region MUSIC FUNCTIONS

    public void PlayMusic(int index, bool restart)
    {
        if (restart) { StopMusic(index); }

        musicList[index].Play();
    }
    public void StopMusic(int index)
    {
        musicList[index].Stop();
    }
    public void ToggleMusic(int index)
    {
        if (musicList[index].isPlaying)
        {
            StopMusic(index);
        }
        else
        {
            PlayMusic(index, true);
        }
    }
    public void SetMusicStereoPan(int index, float value)
    {
        musicList[index].panStereo = Mathf.Clamp(value, -1.0f, 1.0f);
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
    public void ResetMusicStereoPan(int index)
    {
        musicList[index].panStereo = 0;
    }
    public void SetMusicVolume(int index, float volume)
    {
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
