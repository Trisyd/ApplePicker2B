using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioSettingsManager : MonoBehaviour
{
    [SerializeField] Slider masterSlider;
    [SerializeField] Slider vfxSlider;

    // Start is called before the first frame update
    void Start()
    {
        masterSlider.value = PlayerPrefs.GetFloat("Master Volume");
        vfxSlider.value = PlayerPrefs.GetFloat("VFX Volume");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void SetMasterVolume()
    {
        float masterVolume = masterSlider.value;
        PlayerPrefs.SetFloat("Master Volume", masterVolume);
    }

    public void SetSFXVolume()
    {
        float vfxVolume = vfxSlider.value;
        PlayerPrefs.SetFloat("VFX Volume", vfxVolume);
    }
}
