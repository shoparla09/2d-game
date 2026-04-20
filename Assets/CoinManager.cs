using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UI;

public class CoinManager : MonoBehaviour
{
    public int coinCount; 
    public Text coinText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //laten zien op scherm
        coinText.text = "Coin count: " + coinCount.ToString();
    }
}
