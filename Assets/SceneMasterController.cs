using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneMasterController : MonoBehaviour
{
    public Slider appleSFXslider;
    //float appleSFXSliderValue = 1;
    public Slider musicSlider;

    public GameObject mainCamera;
    public GameObject audioManager;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        DontDestroyOnLoad(mainCamera);
        //DontDestroyOnLoad(audioManager);
    }

    // Update is called once per frame
    void Update()
    {
        //float appleSFXVolumeConstant = slider.value;
        mainCamera.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Master Volume");

    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Settings");
        //musicSlider.normalizedValue = PlayerPrefs.HasKey("Master Volume") ? PlayerPrefs.GetFloat("Master Volume") : 1;
        //musicSlider.Set(PlayerPrefs.GetFloat("Master Volume") , 1);
        //appleSFXslider.value = PlayerPrefs.GetFloat("Master Volume");
        //mainCamera.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Master Volume");

        //musicSlider.value = PlayerPrefs.GetFloat("Master Volume");

        //musicSlider.value = appleSFXSliderValue;
    }

    public void LoadGame()
    {
        Debug.Log("Loading Game");
        //DontDestroyOnLoad(mainCamera);
        SceneManager.LoadScene("Primary");
        mainCamera.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Master Volume",1);
        FallApple.FindObjectOfType<AudioSource>().volume = PlayerPrefs.GetFloat("SFX Volume",1);
    }

    public void CloseGame()
    {
        Application.Quit();
    }

    public void SetMasterVolume()
    {
        PlayerPrefs.SetFloat("Master Volume", musicSlider.value);
    }

    public void SetAppleSFXVolume()
    {
        PlayerPrefs.SetFloat("SFX Volume", appleSFXslider.value);
        //appleSFXSliderValue = appleSFXslider.value;
    }
}
