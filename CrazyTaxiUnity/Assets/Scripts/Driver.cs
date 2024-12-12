using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{

    [SerializeField] float moveSpeed = 0.01f;
    [SerializeField] float rotSpeed = 0.07f;

    void Start()
    {
        Application.targetFrameRate = 100;
    }


    void Update()
    {
        transform.Translate(0, moveSpeed, 0);
        transform.Rotate(0, 0, rotSpeed);

    }
}
