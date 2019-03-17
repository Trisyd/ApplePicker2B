using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController2 : MonoBehaviour
{
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActuallySetMasterVolume()
    {
        if (PlayerPrefs.HasKey("Master Volume")) { audioSource.volume = PlayerPrefs.GetFloat("Master Volume"); }
        else {audioSource.volume = 1;}
    }
}
