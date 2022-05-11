using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static bool muteAudio = false;
    public AudioSource Audio;
    public static void AudioActive(AudioSource audioSource)
    {
        if (muteAudio)
            audioSource.mute = true;
        else
            audioSource.mute = false;
    }

    public void Start()
    {
        if (muteAudio)
            Audio.mute = true;
        else
            Audio.mute = false;
    }
}
