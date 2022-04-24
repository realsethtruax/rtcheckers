using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class GameManager : MonoBehaviour
{

    private int rowCount = 8;
    private int columnCount = 12;

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
        boardTileMap.orientationMatrix.SetTRS(offset, Quaternion.identity, Vector3.one);
        ghostTileMap.orientationMatrix.SetTRS(offset, Quaternion.identity, Vector3.one);
        checkerTileMap.orientationMatrix.SetTRS(offset, Quaternion.identity, Vector3.one);

        InstantiateBoard(rowCount, columnCount, boardTileMap);
        SetupPieces(rowCount, columnCount, checkerTileMap, redChecker, grayChecker);
    }

    private void InstantiateBoard(int rows, int columns, Tilemap map)
    {
        for (int row = 0; row < rows; row++){
            for (int column = 0; column < columns; column++){
                if ((row + column) % 2 == 0){
                    map.SetTile(new Vector3Int(column, row, 0), redTile);
                }
                else{
                    map.SetTile(new Vector3Int(column, row, 0), grayTile);
                }
            }
        }
    }

    private void SetupPieces(int rows, int columns, Tilemap map, TileBase colorOne, TileBase color2) 
    {
        int threshold = ((rows / 2) - 1);

        for (int row = 0; row < rows; row++){
            for (int column = 0; column < columns; column++){
                if ((row + column) % 2 == 0){
                    if ( 0 <= row && row < threshold ) {
                        map.SetTile(new Vector3Int(column, row, 0), redChecker);
                    } else if ( row >= (rows - threshold) && row < rows ) {
                        map.SetTile(new Vector3Int(column, row, 0), grayChecker);
                    }
                }
            }
        }
    }

    private void MoveChecker(int startRow, int startColumn, int endRow, int endColumn) {
    
    }
}
