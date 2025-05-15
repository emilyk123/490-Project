using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] int moveSpeed = 8;
    [SerializeField] Camera mainCamera;
    public GameObject UI;
    public bool canMove = true;
    public GameObject inventory;

    void Update()
    {
        if (canMove)
        {
            transform.position = new Vector3(transform.position.x + Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime,
                                             transform.position.y + Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime,
                                              0);
        }

if (Input.GetKeyDown(KeyCode.E))
{
    if (inventory != null)
    {
        bool anyChildActive = false;
        foreach (Transform child in inventory.transform)
        {
            if (child != null && child.gameObject.activeSelf)
            {
                anyChildActive = true;
                break;
            }
        }

        if (anyChildActive)
        {
            // If children visible, hide all children AND deactivate parent
            foreach (Transform child in inventory.transform)
            {
                child.gameObject.SetActive(false);
            }
            inventory.SetActive(false);
        }
        else
        {
            // If children hidden, activate parent and show all children
            inventory.SetActive(true);
            foreach (Transform child in inventory.transform)
            {
                child.gameObject.SetActive(true);
            }
        }
    }
}
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Door"))
        {
            transform.localPosition = new Vector3(10.1f, -3.04f, 0);
            mainCamera.transform.position = new Vector3(23.55f, 0.59f, -10);
            UI.SetActive(false);
            inventory.SetActive(false);
        }

        if (collision.CompareTag("Shop"))
        {
            canMove = false;
            UI.SetActive(true);
        }
    }
}
