using System.Collections;
using UnityEngine;

public class Movable : MonoBehaviour
{
    private float travelTime;
    private float travelSpeed = 1f;
    public bool Idle { get; set; } = true;

    public void MoveToPosition(Vector3 targetPosition)
    {
        StartCoroutine(StepToPositionCo(targetPosition));
    }
    public IEnumerator StepToPositionCo(Vector3 targetPosition)
    {
        var playerX = (int)transform.position.x;
        var playerZ = (int)transform.position.z;
        var targetX = (int)targetPosition.x;
        var targetZ = (int)targetPosition.z;

        while (playerX != targetX || playerZ != targetZ)
        {
            if (playerX == targetX)
            {
                playerX = targetX;
            }
            else
            {
                if (playerX > targetX)
                {
                    playerX = playerX - 1;
                }
                else
                {
                    playerX = playerX + 1;
                }
            }
            playerZ = playerZ == targetZ ? playerZ = targetZ : playerZ > targetZ ? playerZ - 1 : playerZ + 1;

            var newPosition = new Vector3(playerX, 0, playerZ);
            yield return MoveActionCo(newPosition);
        }
    }
    public IEnumerator MoveActionCo(Vector3 targetPosition)
    {
        if (travelSpeed < 0f)
        {
            Debug.LogWarning("Speed must be positive number.");
            yield break;
        }

        travelTime = 0;
        Idle = false;

        do
        {
            travelTime += travelSpeed * Time.deltaTime;

            if (travelTime > 1)
                travelTime = 1;

            transform.position = Vector3.Lerp(transform.position, targetPosition, Easeing(travelTime));
            yield return null;

        } while (travelTime != 1);

        Idle = true;
    }
    private float Easeing(float time)
    {
        return time * time;
    }
    public void SetTravelSpeed(float speed) => travelSpeed = speed;
}
