using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Author: Matthew Makepeace
 * Student Number: 101179668
 * Last Modified: October 2, 2020
 * Program Description: This script is for the player controller, it detects input to make the player
   move, and detects if the player is going out of camera view.
     */

public class PlayerController : MonoBehaviour
{
    // float for the players speed.
    public float moveSpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TouchMove();
    }

    // TouchMove funtion to detect input for player movement, 
    void TouchMove()
    {
        if (Input.GetMouseButton(0))
        {
            // Verctor3 value for where the mouse click position.
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (transform.position.x <= -613) // Detects if the player if going offscreen in the left side.
            {
                transform.Translate(10, 0, 0);
            }

            else if (transform.position.x >= 613) // Detects if the player offscreen in the right side.
            {
                transform.Translate(-10, 0, 0);
            }
            else // move the player, as long as it's in camera view.
            {
                transform.Translate(mousePos.x / 200, 0, 0);
            }
        }
    }
}
