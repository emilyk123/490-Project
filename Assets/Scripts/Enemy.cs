using UnityEngine;

public class Enemy : MonoBehaviour
{
    public PlayerUIScript player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Bullet"))
        {
            player.IncreaseExp(10);
            Destroy(gameObject);
        }
    }
}
