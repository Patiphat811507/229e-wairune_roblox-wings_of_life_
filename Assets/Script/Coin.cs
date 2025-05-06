using UnityEngine;

public class Coin : MonoBehaviour
{
    public int coinValue = 1;
    public AudioClip pickupSound;
    public float volume = 1f;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            CoinManager coinManager = FindObjectOfType<CoinManager>();
            if (coinManager != null)
            {
                coinManager.AddCoin(coinValue);
            }

           
            AudioSource.PlayClipAtPoint(pickupSound, transform.position, volume);

            Destroy(gameObject); 
        }
    }
}
