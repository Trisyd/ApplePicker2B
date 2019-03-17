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
        if (Input.GetMouseButtonDown(0)) { Time.timeScale = 1; }

        transform.Translate(Vector2.left * oscillationSpeed * Time.deltaTime);

        if (UnityEngine.Random.value < reverseChance) { oscillationSpeed *= -1; }
        if (transform.position.x > 6.5 || transform.position.x < -6.5) { oscillationSpeed *= -1; }
    }

    void SpawnApple() { Instantiate(apple, transform.localPosition, Quaternion.identity); }
}