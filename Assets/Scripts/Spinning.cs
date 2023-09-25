using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinning : MonoBehaviour
{
    [SerializeField] private float rotX;
    [SerializeField] private float rotY;
    [SerializeField] private float rotZ;
    //[SerializeField] private float speed = 25f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotX, rotY, rotZ);
    }
}
