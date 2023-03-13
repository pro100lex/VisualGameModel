using UnityEngine;
using UnityEngine.UI;
using Zenject;

public class CoinsUI : MonoBehaviour
{
    [SerializeField] private Text _render;
    [SerializeField] private Animator _animator;

	[Inject] private Coins _coins;
	private int _amount;

    private void Awake()
    {
	    _amount = PlayerPrefs.GetInt("Coins", 0);
    }

    public void AddCoins(int coins)
    {
		_coins.OnPickUpCoin();
        _render.text = $"Coins: {coins}";
        _animator.SetTrigger("OnPickupCoin");
        PlayerPrefs.SetInt("Coins", coins);
    }

    public void DiscardCoins(int price)
    {
		if (_coins.TryDiscard(price))
		{
			_render.text = $"Coins: {_amount}";
        	_animator.SetTrigger("OnPickupCoin");
        	PlayerPrefs.SetInt("Coins", _amount);
		}
    }

	private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Contains("Coin"))
            _coins.OnPickUpCoin();
    }
}