using System;
using UnityEngine;

[Serializable]
public struct StateObject
{
    public PlayerPiece player;
    public LayerMask playerLayer;
    public LayerMask gameBoardLayer;
}

