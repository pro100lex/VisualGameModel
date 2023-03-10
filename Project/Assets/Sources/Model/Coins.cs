using UnityEngine;

public class Coins : MonoBehaviour
{  
    [SerializeField] private Animator _animator;
    [SerializeField] private Root _root;
    
    public int Amount;
    
    public void OnPickupCoin()
    {
        Amount++;
        _animator.SetTrigger("OnPickupCoin");
        _root.ChangeText();
    }

    public bool TryDiscard(int price)
    {
        if (Amount < price)
            return false;

        Amount -= price;
        
        _animator.SetTrigger("OnPickupCoin");
        _root.ChangeText();
        return true;
    }
}