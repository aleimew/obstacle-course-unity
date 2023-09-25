using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{

    [SerializeField] private float speed;
    // private int stopTimer = -1;

    // Start is called before the first frame update
    void Start()
    {
        PrintInstruction();
    }

    // Update is called once per frame
    void Update()
    {
        MoveCharacter();
    }

    void MoveCharacter()
    {
        float xDir = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float zDir = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        transform.Translate(xDir, 0f, zDir);
    }

    // void stopCharacter()
    // {
    //     float xDir = Input.GetAxis("Horizontal") * Time.deltaTime * 0;
    //     float zDir = Input.GetAxis("Vertical") * Time.deltaTime * 0;
    //     transform.Translate(xDir, 0f, zDir);
    // }

    void PrintInstruction()
    {
        Debug.Log("Welcome to the game");
        Debug.Log("Move your player with WASD or arrow keys");
        Debug.Log("Don't hit the walls!");
    }
}