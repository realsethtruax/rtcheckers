using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class CheckerBoard : MonoBehaviour
{
    private bool gameOver = false;

    private void Awake()
    {
        DrawBoard();
    }

    private void Start()
    {
        SetUpPieces();   
    }

    private void DrawBoard()
    {
        throw new NotImplementedException();
    }

    private void SetUpPieces()
    {
        throw new NotImplementedException();
    }


}
