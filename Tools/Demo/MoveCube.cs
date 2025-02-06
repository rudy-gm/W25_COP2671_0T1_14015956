using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MoveCube : MonoBehaviour
{
    public GameObject cube;
    [SerializeField] float moveDuration = 2f;
    [SerializeField] float moveSpeed = 5f;
    Vector3 currentPosition;

    private void Start()
    {
        currentPosition = transform.position;
        StartCoroutine(MoveCubeCo());
    }

    IEnumerator MoveCubeCo()
    {
        while (true)
        {
            yield return new WaitForSeconds(moveDuration);
            //transform.position += Vector3.forward * moveSpeed * Time.deltaTime;
            Instantiate(cube);
            ///
            yield return null;
        }
    }
}
