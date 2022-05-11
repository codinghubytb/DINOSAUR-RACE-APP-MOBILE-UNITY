using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class PanelSettings : MonoBehaviour
{
    public GameObject panelSettings;
    public AudioSource audioSource;
    public Button btnAudio;
    public Sprite audioImage;
    public Sprite noAudioImage;


    public void Start()
    {
        ImageAudio();
    }

    public void ClosePanel()
    {
        panelSettings.SetActive(false);
    }

    public void ButtonAudio()
    {
        AudioManager.muteAudio = !AudioManager.muteAudio;
        AudioManager.AudioActive(audioSource);
        ImageAudio();
    }

    public void ImageAudio()
    {
        if (AudioManager.muteAudio)
            btnAudio.image.sprite = noAudioImage;
        else
            btnAudio.image.sprite = audioImage;
    }
}
