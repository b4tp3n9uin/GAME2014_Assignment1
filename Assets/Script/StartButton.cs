using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/*
 * Author: Matthew Makepeace
 * Student Number: 101179668
 * Last Modified: September 26, 2020
 * Program Description: Script for the Play Button Behaviour to take the
   user to the Game Level Scene.
     */

public class StartButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Event handler for the On StartButtonPressed event
    public void OnStartButtonPressed()
    {
        Debug.Log("Start Button Pressed!");
        SceneManager.LoadScene("Play");
    }

}
