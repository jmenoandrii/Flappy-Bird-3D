using System;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField]
    private Text coinText;

    [SerializeField]
    private GameObject endPanel;

    public void ChangeCoinText(int value)
    {
        coinText.text = String.Format("Coins: {0}", value);
    }

    public void EnableEndPanel()
    {
        endPanel.SetActive(true);
    }
}
