using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    //Game Logic Flows
    private bool gameOver = false;
    private int playerTurn;

    //Checker Game Object
    public GameObject checkerObject;

    //Board
    int[,] board = new int[8,8];
    

    // Start is called before the first frame update
    void Start()
    {
        playerTurn = 0;

        SetUpBoard();
    }

    // Update is called once per frame
    void Update()
    {
        //while (gameOver == false) {
            switch (playerTurn) {
                case 0:
                    //Player 0 Turn Logic
                    Debug.Log("Set turn to player: 0");
                    playerTurn = 1;
                    break;
                case 1:
                    //Player 1 Truen Logic
                    Debug.Log("Set turn to player: 1");
                    playerTurn = 0;
                    break;
            }
        //}
    }
    private void SetUpBoard()
    {
        float boardOffsetX = -3.5f;
        float boardOffsetY = -3.5f;

        //Spawn Gray Team Checkers

        //Spawn Red Team Checkers
    }

}
