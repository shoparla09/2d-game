using UnityEngine;

public class FinishPoint : MonoBehaviour
{
    public CoinManager cm;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Verifies two conditions: (1) the colliding object is tagged as "character", and (2) the player has collected exactly 3 coins
        // When both conditions are met, the level is completed
        // Generated with Claude Haiku 4.5

        if (collision.CompareTag("character") && cm.coinText.ToString() == "3")
        {
            // code to finish the level
            Debug.Log("You won!!!");
        }
    }

}
