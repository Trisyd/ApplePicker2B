using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSettingsManager : MonoBehaviour
{
    public GameObject neededSceneControllerObject;
    public AudioSource masterAudioSource;
    public GameObject neededAppleObject;
    public AudioSource appleSFXaudio;
    [SerializeField] Slider masterSlider;
    [SerializeField] Slider vfxSlider;

    // Start is called before the first frame update
    void Start()
    {
        neededSceneControllerObject = GameObject.FindGameObjectWithTag("GameController");
        masterAudioSource = neededSceneControllerObject.GetComponent<AudioSource>();
        //masterAudioSource = FindObjectOfType<AudioSource>();
        neededAppleObject = GameObject.Find("Apple");
        appleSFXaudio = neededAppleObject.GetComponent<AudioSource>();

        if (PlayerPrefs.HasKey("Master Volume")) { masterSlider.value = PlayerPrefs.GetFloat("Master Volume"); }
        else { masterSlider.value = 1; }
        if (PlayerPrefs.HasKey("SFX Volume")) { vfxSlider.value = PlayerPrefs.GetFloat("SFX Volume"); }
        else { vfxSlider.value = 1; }
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetMasterVolume()
    {
        float masterVolume = masterSlider.value;
        PlayerPrefs.SetFloat("Master Volume", masterVolume);
        //audioSource.volume = masterVolume;
        //AudioController2.ActuallySetMasterVolume(masterVolume);
        masterAudioSource.volume = masterVolume;
        Debug.Log("Master Volume has changed to:" + masterVolume);
    }

    public void SetSFXVolume()
    {
        float sfxVolume = vfxSlider.value;
        PlayerPrefs.SetFloat("SFX Volume", sfxVolume);
        //appleSFXaudio.volume = sfxVolume;
        Debug.Log("SFX Volume has changed to:" + sfxVolume);
    }
}
