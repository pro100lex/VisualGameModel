using UnityEngine;

public class CoinsPresenter : MonoBehaviour
{
    [SerializeField] private Coins _coinsModel;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Contains("Coin"))
            _coinsModel.OnPickupCoin();
    }
}
