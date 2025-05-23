using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bulletPrefab;      // Assign in Inspector
    public Transform firePoint;          // Assign in Inspector
    bool canShoot = true;

    void Update()
    {
        // Aim the firePoint toward the mouse
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = (mousePosition - firePoint.position).normalized;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        firePoint.rotation = Quaternion.Euler(0f, 0f, angle);

        // Fire when button is clicked
        if (Input.GetButtonDown("Fire1") && canShoot)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Instantiate bullet at firePoint position and rotation
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Shop"))
        {
            canShoot = false;
        }
    }
}