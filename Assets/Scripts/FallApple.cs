﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallApple : MonoBehaviour
{
    /*This script deals with the player stats (such as lives and score), organizes a resulting player score into player prefs and 
     * manages the SFX audio of the fruit being collected by the basket*/

    [SerializeField] float fallSpeed = 2f;

    public AudioSource audioSource;
    public AudioClip appleCollectionAudioSFX;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(audioSource);
        DontDestroyOnLoad(appleCollectionAudioSFX);

        audioSource.volume = PlayerPrefs.GetFloat("SFX Volume", 1);
        //Debug.Log("SFX Volume set to" + audioSource.volume);
    }

    // Update is called once per frame
    void Update() { transform.Translate(Vector2.down * fallSpeed * Time.deltaTime); }
    
    void OnTriggerEnter2D(Collider2D collision) //This function handles the collision between the basket and falling fruit
    {
        if(collision.tag == "Player")
        {
            Debug.Log("Collision Occurred");
            BasketControl.playerScore += 100;
            audioSource.PlayOneShot(appleCollectionAudioSFX);

            Destroy(gameObject.GetComponent<SpriteRenderer>());
            Destroy(gameObject.GetComponent<Collider2D>());
            Destroy(gameObject, 0.5f);
        }

        else
        {
            Debug.Log("Collision With Bottom Occurred");
            BasketControl.lives -= 1;
            if (BasketControl.lives == 0)
            {
                ManageHighScores(BasketControl.playerScore);
                SceneManager.LoadScene("GameOver");
                BasketControl.lives = 2;
                BasketControl.playerScore = 0;
            }
            Destroy(gameObject);
        }
    }

    public void ManageHighScores(int s) //this function manages the high scores, ordering them correctly after every new score
    {
        int scoreCount = 1;
        while (scoreCount < 11)
        {
            if (PlayerPrefs.HasKey("HighScore" + scoreCount))
            {
                if (s > PlayerPrefs.GetInt("HighScore" + scoreCount))
                {
                    int scoreCountFromBottom = 10;
                    while (scoreCountFromBottom > scoreCount)
                    {
                        if (PlayerPrefs.HasKey("HighScore" + scoreCountFromBottom))
                        {
                            PlayerPrefs.SetInt("HighScore" + scoreCountFromBottom, PlayerPrefs.GetInt("HighScore" + (scoreCountFromBottom - 1)));
                        }
                        scoreCountFromBottom -= 1;
                        continue;
                    }
                    PlayerPrefs.SetInt("HighScore" + scoreCount, s);
                    break;
                }

                else
                {
                    scoreCount += 1;
                    continue;
                }
            }
            else { PlayerPrefs.SetInt("HighScore" + scoreCount, s); }
        }
    }
}
