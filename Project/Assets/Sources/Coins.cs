using UnityEngine;
using UnityEngine.UI;

public class Coins : MonoBehaviour
{
    [SerializeField] private CoinsUI _ui;
    
    public int Amount;

    public Coins(int initAmount)
    {
        Amount = initAmount;
    }

    public void OnPickUpCoin()
    {
        Amount++;
    }

    public bool TryDiscard(int price)
    {
        if (Amount < price)
            return false;

        Amount -= price;
        
        return true;
    }
}
