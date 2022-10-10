using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /* 
     4 variables with the player information
     */
    // this variable saves the player's age //
    public int playerAge = 33;
    // this variable saves the player's speed //
    public float playerSpeed = 3.125f;

    //this variable saves the player's username //
    private string playerName = "Mario Pons";
    // this variable saves if the game is over //
    [SerializeField] private bool isGameOver = false; 

}