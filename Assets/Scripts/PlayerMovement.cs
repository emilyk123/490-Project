using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] int moveSpeed = 8;
    [SerializeField] Camera mainCamera;
    public GameObject UI;
    bool canMove = true;

    void Update()
    {
        if (canMove)
        {
            transform.position = new Vector3(transform.position.x + Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime,
                                             transform.position.y + Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime,
                                              0);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Door"))
        {
            transform.localPosition = new Vector3(10.1f, -3.04f, 0);
            mainCamera.transform.position = new Vector3(23.55f, 0.59f, -10);
            UI.SetActive(false);
        }

        if (collision.CompareTag("Shop"))
        {
            canMove = false;
            UI.SetActive(true);
        }
    }
}
