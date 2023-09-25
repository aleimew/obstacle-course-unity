using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropObject : MonoBehaviour
{
    MeshRenderer render;
    Rigidbody body;
    Material mat;
    Color startingColor;


    [SerializeField] private float timeToDrop = 2f;
    [SerializeField] private float timeToDestroy = 10f;

    private float timer = 0f;


    // Start is called before the first frame update
    void Start()
    {
        render = GetComponent<MeshRenderer>();
        body = GetComponent<Rigidbody>();
        mat = render.material;
        startingColor = mat.color;

        render.enabled = false;
        body.useGravity = false;

        adjustValuesforTimer();
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        //Debug.Log(timer);
        if (timer > timeToDrop && render.enabled == false)
        {
            Debug.Log(timeToDrop + " Seconds have passed");
            render.enabled = true;
            body.useGravity = true;
            Debug.Log("Gravity has been enabled");
            timer = 0f;
        }

        if (timer > timeToDestroy && render.enabled == true)
        {
            resetSpawn();
            timer = 0f;
        }
    }

    private void resetSpawn()
    {
        render.enabled = false;
        body.useGravity = false;
        body.velocity = Vector3.zero;
        body.angularVelocity = Vector3.zero;
        transform.position =
        new Vector3(
            Random.Range(-2.5f, 9.5f),
            10f,
            Random.Range(-5f, 9.5f)
            );
        transform.rotation = Quaternion.identity;
        render.material.color = startingColor;
        gameObject.tag = "Not Hit";
    }

    void adjustValuesforTimer()
    {
        timeToDrop *= 200;
        timeToDestroy *= 200;
    }
}
