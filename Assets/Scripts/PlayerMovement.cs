using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    private float movementX;
    private float movementY;
    private float movementJump;


    public TextMeshProUGUI countText;

    public int count;


    void Start()
    {
        rb = GetComponent<Rigidbody>();
        movementJump = 0;
        count = 0;
        SetText();
        Console.WriteLine("empezamos");
    }

    private void OnMove(InputValue movementValue)
    {
        Vector2 movement = movementValue.Get<Vector2>();

        movementX = movement.x;
        movementY = movement.y;

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        /*Vector3 movement = new Vector3(movementX, 0.0f, movementY);*/
        Vector3 movement = new Vector3(movementX, movementJump, movementY);
        rb.AddForce(movement * speed);
        movementJump = 0;
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        count++;
        SetText();

        if (count == 12)
        {
            SceneManager.LoadScene("FinalScene");

        }

    }

    private void SetText()
    {

        countText.text = "Score " + count.ToString();
    }

    private void OnJump()
    {

        if (transform.position.y <= 0.5)
        {
            movementJump = 20.0f;
        }

    }
}
