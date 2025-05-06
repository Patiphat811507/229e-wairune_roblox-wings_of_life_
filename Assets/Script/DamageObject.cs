using UnityEngine;

public class DamageObject : MonoBehaviour
{
    public int damageAmount = 2;
    public AudioClip hitSound; 
    public float volume = 1f;

    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerHealth player = other.GetComponent<PlayerHealth>();
        if (player != null)
        {
            player.TakeDamage(damageAmount);

            
            if (hitSound != null)
            {
                AudioSource.PlayClipAtPoint(hitSound, transform.position, volume);
            }

            Destroy(gameObject);
        }
    }
}
