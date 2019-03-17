using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneMasterController : MonoBehaviour
{
    //This script handles all scene changes, and maintains the mainCamera as well as itself

    public static SceneMasterController Instance;

    private Text hstext;

    public GameObject mainCamera;
    public AudioClip masterAudioClip;

    public void Awake() { Instance = this; }

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        DontDestroyOnLoad(mainCamera);
    }

    public void LoadMenu() { SceneManager.LoadScene("Settings"); }

    public void LoadScores() { SceneManager.LoadScene("GameOver"); }

    public void LoadGame() { SceneManager.LoadScene("Primary"); }

    public void CloseGame() { Application.Quit(); }
}
