using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Blinking : MonoBehaviour
{
    [SerializeField] float blinkRate = 1;

    private TMP_Text blinkText;
    Color blinkColor;
    bool isOn = false;

    private void Awake()
    {
        blinkText = GetComponent<TMP_Text>();
        blinkColor = blinkText.color;
    }
    private void Start()
    {
        StartCoroutine(BlinkTextCo());
    }
    IEnumerator BlinkTextCo()
    {
        while (true) 
        { 
            float blinkValue = Random.Range(0, blinkRate);
            Debug.Log(blinkValue);
            yield return new WaitForSeconds(blinkValue);
            if (isOn)
            {
                blinkText.color = Color.clear;                
                isOn = false;
            }
            else
            {
                blinkText.color = blinkColor;
                isOn = true;
            }
            yield return null;
        }
    }
}
