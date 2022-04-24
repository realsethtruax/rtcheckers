using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Board : MonoBehaviour
{
    private TileBase redTile;
    private TileBase grayTile;

    public void Instantiate(int rows, int columns, Tilemap map, Vector3Int offset)
    {
        for (int row = 0; row < rows; row++)
        {
            for (int column = 0; column < columns; column++)
            {
                if ((row + column) % 2 == 0)
                {
                    map.SetTile(new Vector3Int(row, column,0), redTile);
                }
                else 
                {
                    map.SetTile(new Vector3Int(row, column, 0), grayTile);
                }
            }
        }
    }

    public void setGrayTile(TileBase tile)
    {
        this.grayTile = tile;
    }

    public void setRedTile(TileBase tile)
    {
        this.redTile = tile;
    }
}
