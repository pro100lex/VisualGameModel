using UnityEngine;
using UnityEngine.UI;

public class Root : MonoBehaviour
{
    [SerializeField] private CoinsPresenter _coinsPresenter;
    [SerializeField] private Text _render;
    
    private Coins _coinsModel;

    public void ChangeText()
    {
        _render.text = $"Coins: {_coinsModel.Amount}";
        PlayerPrefs.SetInt("Coins", _coinsModel.Amount);
    }

    private void Awake()
    {
        _coinsModel = new Coins();
    }
}
