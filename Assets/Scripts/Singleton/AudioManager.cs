using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance { get; private set; }



    private AudioSource audioSource;

    private void Awake()
    {

        if (Instance != null && Instance != this)
        {
            Destroy(this);

        }
        else
        {
            Instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
        audioSource = GetComponent<AudioSource>();

    }

    public void PlaySoundOneShot(AudioClip audioClip)
    {
        audioSource.PlayOneShot(audioClip);
    }
   

}
