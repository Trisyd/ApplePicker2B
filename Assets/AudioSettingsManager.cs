using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSettingsManager : MonoBehaviour
{
    public GameObject neededGameObject;
    public AudioSource audioSource;
    [SerializeField] Slider masterSlider;
    [SerializeField] Slider vfxSlider;

    // Start is called before the first frame update
    void Start()
    {
        neededGameObject = GameObject.FindGameObjectWithTag("GameController");
        audioSource = FindObjectOfType<AudioSource>();
        if (PlayerPrefs.HasKey("Master Volume")) { masterSlider.value = PlayerPrefs.GetFloat("Master Volume"); }
        else { masterSlider.value = 1; }
        if (PlayerPrefs.HasKey("SFX Volume")) { vfxSlider.value = PlayerPrefs.GetFloat("VFX Volume"); }
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
        audioSource = neededGameObject.GetComponent<AudioSource>();
        audioSource.volume = masterVolume;
        Debug.Log("Master Volume has changed to:" + masterVolume);
    }

    public void SetSFXVolume()
    {
        float vfxVolume = vfxSlider.value;
        PlayerPrefs.SetFloat("VFX Volume", vfxVolume);
    }
}
