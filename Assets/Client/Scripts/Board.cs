using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class Board : MonoBehaviour
{
    public static Board Instance { get; private set; }
    public Row[] rows;
    publiclic Tile[,] Tiles { get; private set; }
}