using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    private int score = 1000;
    private int hitCounter;
    System.Random scoreCounter = new System.Random();

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag != "Hit")
        {
            score -= scoreCounter.Next(25, 50);
            hitCounter++;

            Debug.Log("You've hit something " + hitCounter + " times!");
            Debug.Log("Your score is: " + score);
        }
    }
}
