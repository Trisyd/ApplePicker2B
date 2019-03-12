using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public Camera audiocamera;
    public AudioSource masterAudiosource;

    // Start is called before the first frame update
    void Start()
    {
        masterAudiosource = audiocamera.GetComponent<AudioSource>();
        masterAudiosource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
