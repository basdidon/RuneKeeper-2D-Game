using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSight : MonoBehaviour
{
    public Player player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            player.onSightEnemy.Add(collision.GetComponent<Enemy>());
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            player.onSightEnemy.Remove(collision.GetComponent<Enemy>());
            if(collision.GetComponent<Enemy>() == player.selectedEnemy)
            {
                player.selectedEnemy = null;
                Destroy(player.clone);
            }
        }
    }
}
