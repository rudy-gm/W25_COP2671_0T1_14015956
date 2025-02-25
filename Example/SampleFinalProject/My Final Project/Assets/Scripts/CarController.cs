using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class CarController : MonoBehaviour
{
    static string Horizontal = nameof(Horizontal);
    static string Vertical = nameof(Vertical);

    NavMeshAgent agent;
    float forwardInput => Input.GetAxis(Vertical);
    float turnInput => Input.GetAxis(Horizontal);

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        agent.Move(transform.forward * forwardInput * agent.speed * Time.deltaTime);
        transform.Rotate(Vector3.up, turnInput * agent.angularSpeed * Time.deltaTime);
    }
}
 