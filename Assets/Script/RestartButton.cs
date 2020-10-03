using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Author: Matthew Makepeace
 * Student Number: 101179668
 * Last Modified: September 26, 2020
 * Program Description: Script for the Play Again Button Behaviour to take the
   user to the Game Level Scene.
     */

public class RestartButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    //Event handler for the OnRestartButtonPressed event
    public void OnRestartButtonPressed()
    {
        Debug.Log("Restart Button Pressed!");
        SceneManager.LoadScene("Play");
    }
}
