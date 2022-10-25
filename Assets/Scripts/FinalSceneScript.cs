using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using TMPro;
using System;
using UnityEngine.SceneManagement;
public class FinalSceneScript : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void OnMove(InputValue movementValue)
    {
        Vector2 movement = movementValue.Get<Vector2>();

        movementX = movement.x;
        movementY = movement.y;


        /*     if ()
             {
                 SceneManager.LoadScene("FinalScene");

             }*/

    }



    // Update is called once per frame
    void FixedUpdate()
    {
        /*Vector3 movement = new Vector3(movementX, 0.0f, movementY);*/
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);




    }
    private void OnTriggerEnter(Collider other)
    {

        SceneManager.LoadScene("MainMenu");

    }
}