using System.Collections;
using UnityEngine;

public class Flash : MonoBehaviour
{
    MeshRenderer meshRenderer;
    bool isActive => meshRenderer.enabled;

    [SerializeField]
    float interval = 0.5f;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        
        if (meshRenderer != null)
        {
            StartCoroutine(ToggleCo());
        }
    }
    private IEnumerator ToggleCo()
    {
        while (gameObject.activeSelf)
        {
            if (isActive)
            {
                meshRenderer.enabled = false;                
            }
            else
            {
                meshRenderer.enabled = true;
            }
            DynamicGI.UpdateEnvironment();
            yield return new WaitForSeconds(interval);
        }
    }


}
