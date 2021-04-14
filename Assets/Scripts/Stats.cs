using UnityEngine;
using UnityEngine.Events;

public class Stats : MonoBehaviour
{
    public UnityEvent<int> ChangeCoinsEvent;

    [SerializeField]
    private int coin;

    private void Awake()
    {
        ChangeCoins(0);
    }

    public void ChangeCoins(int value)
    {
        coin += value;
        ChangeCoinsEvent.Invoke(coin);
    }
}
