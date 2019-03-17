using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneMasterController : MonoBehaviour
{
    //public Canvas canvas;

    //public Slider appleSFXslider;
    //float appleSFXSliderValue = 1;
    //public Slider musicSlider;

    public static SceneMasterController Instance;

    private Text hstext;

    public GameObject mainCamera;
    //public GameObject audioManager;

    //public AudioSource masterAudioSource;
    public AudioClip masterAudioClip;

    public void Awake()
    {
        Instance = this;
    }

    //private void Awake()
    //{
    //    PlayerPrefs.SetFloat("Master Volume", 1);
    //    PlayerPrefs.SetFloat("VFX Volume", 1);
    //}

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        DontDestroyOnLoad(mainCamera);
        //DontDestroyOnLoad(audioManager);
        //DontDestroyOnLoad(audioManager);
    }

    // Update is called once per frame
    void Update()
    {
        //float appleSFXVolumeConstant = slider.value;
        //mainCamera.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Master Volume");

    }

    //public static void ActuallySetMasterVolume(float v)
    //{
        
    //}

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

    public void LoadScores()
    {
        SceneManager.LoadScene("GameOver");
        //hstext = canvas.GetComponent<Text>();
        //hstext.text = "Test String Working";
        //Debug.Log("String should be up in high scores");
        //highScores = GetComponent<Text>().text;
    }

    public void LoadGame()
    {
        Debug.Log("Loading Game");
        //DontDestroyOnLoad(mainCamera);
        SceneManager.LoadScene("Primary");
        //mainCamera.GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("Master Volume",1);
        FallApple.FindObjectOfType<AudioSource>().volume = PlayerPrefs.GetFloat("SFX Volume",1);
    }

    public void CloseGame()
    {
        Application.Quit();
    }

    //public void SetMasterVolume()
    //{
    //    PlayerPrefs.SetFloat("Master Volume", musicSlider.value);
    //}

    //public void SetAppleSFXVolume()
    //{
    //    playerprefs.setfloat("sfx volume", applesfxslider.value);
    //    applesfxslidervalue = applesfxslider.value;
    //}
}
