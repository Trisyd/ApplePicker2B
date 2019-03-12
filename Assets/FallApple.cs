using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FallApple : MonoBehaviour
{
    //TODO figure out how to correctly access the canvas

    [SerializeField] float fallSpeed = 2f;
    public AudioSource audioSource;
    public AudioClip appleCollectionAudioSFX;
    //string scoreText = "0";

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(audioSource);
        DontDestroyOnLoad(appleCollectionAudioSFX);

        //Canvas canvas = GetComponent<Canvas>();
        //Text scoreTracker = canvas.GetComponent<Text>();
        //scoreText = scoreTracker.text;
        //appleCollectionAudioSFX = audioSource.GetComponent<AudioClip>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.down * fallSpeed * Time.deltaTime);
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            Debug.Log("Collision Occurred");
            BasketControl.playerScore += 100;
            audioSource.PlayOneShot(appleCollectionAudioSFX);
            //BasketControl.AudioSource.PlayOneShot(buttonAudioClip);
            //BasketControl.finalScore.text = BasketControl.playerScore.ToString();

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
                SceneManager.LoadScene("Settings");
                BasketControl.lives = 2;
                BasketControl.playerScore = 0;
                //TreeOscillator.FindObjectOfType<Transform>().transform.position.x = 0;
            }
            //BasketControl.finalScore.text = BasketControl.playerScore.ToString();
            Destroy(gameObject);
        }
    }
}
