﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TEST : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefsController.SetMasterVolume(0.4f);
        Debug.Log(PlayerPrefsController.GetMasterVolume()+ " This is the returned volume");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
