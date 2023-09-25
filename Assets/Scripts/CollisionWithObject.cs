using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithObject : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        // change the color of the wall to black
        if (other.gameObject.tag == "Player" && gameObject.tag != "Hit")
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
            gameObject.tag = "Hit";
        }
    }
}
