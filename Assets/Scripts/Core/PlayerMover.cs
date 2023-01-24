using UnityEngine;
using UnityEngine.AI;
using Zenject;

public class PlayerMover : MonoBehaviour
{
  private const float ZeroSpeed = 0;
  
  private NavMeshAgent _navMeshAgent;
  private DynamicJoystick _dynamicJoystick;
  
  [Inject]
  private void Construct(DynamicJoystick dynamicJoystick)
  {
    _navMeshAgent = GetComponent<NavMeshAgent>();
    _dynamicJoystick = dynamicJoystick;
  }
  
  private void Update()
  {
    Move();
  }

  private void Move()
  {
    Vector2 input = new Vector2(_dynamicJoystick.Horizontal, _dynamicJoystick.Vertical);

    if (input.x != ZeroSpeed || input.y != ZeroSpeed)
    {
      Vector3 moveDirection = new Vector3(input.x, ZeroSpeed, input.y);
      Vector3 newPosition = transform.position + moveDirection;
      _navMeshAgent.SetDestination(newPosition);
      transform.LookAt(newPosition);
    }
    else
      _navMeshAgent.SetDestination(transform.position);
  }
}