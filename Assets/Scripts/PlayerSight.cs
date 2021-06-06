using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSight : MonoBehaviour
{
    public PlayerContorller playerContorller;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            playerContorller.onSightEnemy.Add(collision.GetComponent<Enemy>());
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            playerContorller.onSightEnemy.Remove(collision.GetComponent<Enemy>());
            if(collision.GetComponent<Enemy>() == playerContorller.selectedEnemy)
            {
                playerContorller.selectedEnemy = null;
                Destroy(playerContorller.clone);
            }
        }
    }
}
