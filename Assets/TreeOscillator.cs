using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeOscillator : MonoBehaviour
{
    [SerializeField] float oscillationSpeed = 5f;
    [SerializeField] float reverseChance = 0.1f;

    public GameObject apple;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        InvokeRepeating("SpawnApple", 1.0f, 0.8f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Time.timeScale = 1;
        }

        transform.Translate(Vector2.left * oscillationSpeed * Time.deltaTime);

        if (UnityEngine.Random.value < reverseChance) { oscillationSpeed *= -1; }
        if (transform.position.x > 6.5 || transform.position.x < -6.5) { oscillationSpeed *= -1; }
    }

    void SpawnApple()
    {
        Instantiate(apple, transform.localPosition, Quaternion.identity);
        //MoveApple();
    }

    //void MoveApple()
    //{
        
    //}
}

//For Reference:
//public class BasketControl : MonoBehaviour
//{
//    [SerializeField] float speed = 1f;
//    //[SerializeField] float lrspeed = 1f;
//    //[SerializeField] float randomChangeChance = 0.1f;

//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        //transform.Translate(0.1f, speed, Time.deltaTime);
//        transform.Translate(Vector2.up * speed * Time.deltaTime);

//        if (Random.value <= randomChangeChance) { speed *= -1; }
//        if (transform.position.y < -2.3 || transform.position.y > 2.3) { speed *= -1; };

//        if (Input.GetKey(KeyCode.LeftArrow)) { transform.Translate(Vector2.left * lrspeed * Time.deltaTime); }
//        if (Input.GetKey(KeyCode.RightArrow)) { transform.Translate(Vector2.right * lrspeed * Time.deltaTime); }
//    }
//}