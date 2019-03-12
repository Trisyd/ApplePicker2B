using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BasketControl : MonoBehaviour
{
    public static int playerScore = 0;
    public static int lives = 2;
    [SerializeField] float speed = 1f;
    public Text finalScore;
    public Text lifeCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }

        finalScore.text = playerScore.ToString();
        lifeCount.text = "Lives: " + lives.ToString() + "/2";
    }
}
