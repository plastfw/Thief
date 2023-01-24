using UnityEngine;
using UnityEngine.AI;
using Zenject;

public class PlayerInstaller : MonoInstaller
{
  [SerializeField] private Player _playerPrefab;
  [SerializeField] private DynamicJoystick _dynamicJoystick;

  public override void InstallBindings()
  {
    Container.Bind<Player>().FromInstance(_playerPrefab).AsSingle().NonLazy();
    Container.Bind<DynamicJoystick>().FromInstance(_dynamicJoystick).AsSingle().NonLazy();
  }
}