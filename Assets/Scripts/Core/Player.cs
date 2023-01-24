using UnityEngine;

public class Player : MonoBehaviour
{
  private PlayerMover _playerMover;
  
  private void Awake()
  {
    _playerMover = GetComponent<PlayerMover>();
  }
}