using UnityEngine;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] int moveSpeed = 8;
    [SerializeField] Camera mainCamera;
    public GameObject UI;
    public bool canMove = true;
    public GameObject inventory;
    public Button healthButton;
    public Button upgradeButton;
    public Button keyButton;
    public List<string> purchasedItems = new List<string>();
    public PlayerUIScript ui;

    bool close = false;
    float damageTimer = 0f;
    float damageInterval = 0.5f;
    bool inEnemyRange = false;

    void Update()
    {
        if (canMove)
        {
            transform.position = new Vector3(
                transform.position.x + Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime,
                transform.position.y + Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime,
                0
            );
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            foreach (Transform child in inventory.transform)
            {
                child.gameObject.SetActive(purchasedItems.Contains(child.name));
            }

            close = !close;
            inventory.SetActive(close);
        }

        if (inEnemyRange)
        {
            damageTimer += Time.deltaTime;
            if (damageTimer >= damageInterval)
            {
                damageTimer = 0f;
                ui.changeHealth(-10);
            }
        }
        else
        {
            damageTimer = 0f;
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

        if (collision.CompareTag("Enemy"))
        {
            inEnemyRange = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            inEnemyRange = false;
        }
    }
}