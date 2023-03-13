using UnityEngine;
using Zenject;

public class GameInstaller : MonoInstaller
{
    public void InstallBidings()
    {
        int amount = PlayerPrefs.GetInt("Coins", 0);
        Coins coins = new Coins(amount);
        Container.Bind<Coins>().FromInstance(coins).AsSingle();
    }
}
