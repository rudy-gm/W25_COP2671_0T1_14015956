using UnityEngine;

public abstract class MoveAction
{
    public int Spaces { get; set; } = 1;
    public Vector3[] Directions { get; set; } = new Vector3[] { Vector3.forward, Vector3.back, Vector3.left, Vector3.right };
}
