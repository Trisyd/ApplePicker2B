using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public static AudioController Instance;

    public AudioSource masterAudiosource;
    private AudioClip masterAudioClip;
    //public static float masterVolume2;

    private void Awake()
    {
        Instance = this;
    }

    //Start is called before the first frame update
    void Start()
    {
        masterAudiosource = GetComponent<AudioSource>();
        
        //masterAudioClip = GetComponent<AudioClip>();
        //masterVolume2 = masterAudiosource.volume;
        //masterAudiosource = audiocamera.GetComponent<AudioSource>();
        //masterAudiosource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActuallySetMasterVolume(float v)
    {
        Debug.Log("master audio source volume is changing");
        masterAudiosource.volume = v;
    }
}
