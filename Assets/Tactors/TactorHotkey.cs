using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TactorHotkey : MonoBehaviour
{
    [SerializeField] private TactorPlayer[] tactorsToPlay;

    [SerializeField] private KeyCode playButton;

    private void Update()
    {
        // Wait for user to press the tactor play button
        if (Input.GetKeyDown(playButton))
        {
            foreach (TactorPlayer tactorPlayer in tactorsToPlay)
            {
                tactorPlayer.Play();
            }
        }
    }
}
