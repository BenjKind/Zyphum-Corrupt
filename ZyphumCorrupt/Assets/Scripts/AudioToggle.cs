using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

[RequireComponent(typeof(Toggle))]
public class AudioToggle : MonoBehaviour
{
    private Toggle AudioToggler;

    public void ToggleAudio()
    {
        AudioToggler = GetComponent<Toggle>();
        if (AudioListener.volume == 0)
        { AudioToggler.isOn = false; }
    }

    public void ToggleAudioOnValueChange(bool audioIn)
    {
        if (audioIn)
        { AudioListener.volume = 0; }
        else
        { AudioListener.volume = 1; }
    }
}