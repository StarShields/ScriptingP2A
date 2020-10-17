using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class AudioManagement : MonoBehaviour
{
    public static AudioManagement Instance = null;

    AudioSource audiosource;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);

            audiosource = GetComponent<AudioSource>();
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void PlaySong(AudioClip clip)
    {
        audiosource.clip = clip;
        audiosource.Play();
    }
}
