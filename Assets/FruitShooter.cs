using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FruitShooter : MonoBehaviour
{
    public GameObject[] fruits;   // drag your 4 fruit prefabs here

    void Update()
    {
        if (Touchscreen.current != null && Touchscreen.current.press.wasPressedThisFrame)
        {
            GameObject chosen = fruits[Random.Range(0, fruits.Length)];
            GameObject fruit = Instantiate(chosen);
            fruit.transform.position = transform.position;
            fruit.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * Random.Range(1200, 1400));
        }
    }
}