using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] int moveSpeed = 8;
    [SerializeField] Camera mainCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime,
                                         transform.position.y + Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime,
                                          0);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Door"))
        {
            transform.localPosition = new Vector3(10.1f, -3.04f, 0);
            mainCamera.transform.position = new Vector3(23.55f, 0.59f, -10);
        }
    }
}
