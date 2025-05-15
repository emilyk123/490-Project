using UnityEngine;

public class EnemyChase : MonoBehaviour
{
    public float speed = 3f;
    [SerializeField] private Transform player;

    void Update()
    {
        if (player != null)
        {
            // Move toward the player
            Vector3 direction = (player.position - transform.position).normalized;
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}
