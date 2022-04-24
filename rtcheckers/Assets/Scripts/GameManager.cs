using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameManager : MonoBehaviour
{

    private int rowCount = 8;
    private int columnCount = 10;

    [SerializeField] Tilemap boardTileMap;
    [SerializeField] Tilemap ghostTileMap;
    [SerializeField] Tilemap checkerTileMap;

    [SerializeField] TileBase redTile;
    [SerializeField] TileBase grayTile;

    [SerializeField] TileBase redChecker;
    [SerializeField] TileBase grayChecker;
    [SerializeField] TileBase redKing;
    [SerializeField] TileBase grayKing;

    Vector3Int offset; 

    private void Awake()
    {
        offset = new Vector3Int(-(columnCount/2), -(rowCount/2), 0);

        InstantiateBoard(rowCount, columnCount, boardTileMap, offset);
        SetupPieces(rowCount, columnCount, checkerTileMap, redChecker, grayChecker, offset);
    }

    private void InstantiateBoard(int rows, int columns, Tilemap map, Vector3Int boardOffset)
    {
        for (int row = 0; row < rows; row++){
            for (int column = 0; column < columns; column++){
                if ((row + column) % 2 == 0){
                    map.SetTile(new Vector3Int(column, row, 0)+ boardOffset, redTile);
                }
                else{
                    map.SetTile(new Vector3Int(column, row, 0)+ boardOffset, grayTile);
                }
            }
        }
    }

    private void SetupPieces(int rows, int columns, Tilemap map, TileBase colorOne, TileBase color2, Vector3Int boardOffset) 
    {
        int threshold = ((rows / 2) - 1);

        for (int row = 0; row < rows; row++){
            for (int column = 0; column < columns; column++){
                if ((row + column) % 2 == 0){
                    if ( 0 <= row && row < threshold ) {
                        map.SetTile(new Vector3Int(column, row, 0) + boardOffset, redChecker);
                    } else if ( row >= (rows - threshold) && row < rows ) {
                        map.SetTile(new Vector3Int(column, row, 0) + boardOffset, grayChecker);
                    }
                }
            }
        }
    }
}
