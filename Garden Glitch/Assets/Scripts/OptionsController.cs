﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;
    [SerializeField] float defaultVolume = 0.8f;

    void Start()
    {
        volumeSlider.value = PlayerPrefsController.GetMasterVolume();
    }

    void Update()
    {
        var musicPlayer = FindObjectOfType<MusicPlayer>();
        if(musicPlayer)
        {
            musicPlayer.setVolume(volumeSlider.value);
        }
        else
        {
            Debug.LogWarning("No music player found.. did you start from splash screen???");
        }
    }

    public void SaveAndExit()
    {
        PlayerPrefsController.SetMasterVolume(volumeSlider.value);
        FindObjectOfType<LevelLoader>().LoadMainMenu();
    }

    public void SetDefaults()
    {
        volumeSlider.value = defaultVolume;
    }
}
