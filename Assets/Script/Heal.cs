using UnityEngine;

public class HealItem : MonoBehaviour
{
    public int healAmount = 1;
    public AudioClip healSound; 
    public float volume = 1f;   

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>().Heal(healAmount);

         
            if (healSound != null)
            {
                AudioSource.PlayClipAtPoint(healSound, transform.position, volume);
            }

            Destroy(gameObject);
        }
    }
}
