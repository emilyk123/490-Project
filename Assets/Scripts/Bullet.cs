using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public float lifeTime = 2f;

    void Start()
    {
        // Destroy the bullet after a short time
        Destroy(gameObject, lifeTime);
    }

    void Update()
    {
        // bullet moves forward in the direction it's facing (right by default)
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}