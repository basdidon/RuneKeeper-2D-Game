using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerContorller : MonoBehaviour
{
    public enum CharacterState {Idle, Moving, Attacking, CastingSpell, Stun, Dead};
    public enum Direction {N, NW, W, SW, S, SE, E, NE};

    public CharacterState playerState = CharacterState.Idle;
    public Direction playerDirection = Direction.S;
    public Vector2 movement;
    public float speed = 10f;
    public Rigidbody2D playerRigidbody;
    public bool isCastSpell;


    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody2D>();

        for(int i = 0; i < 180; i++)
        {
            Debug.Log("sin " + i + " = " + Mathf.Cos((i*Mathf.PI)/180));
        }
    }

    private void FixedUpdate()
    {
        playerRigidbody.velocity = movement * speed;
        DrawLineOfSight();
    }


    //input
    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();

        if(movement.x < 0)
        {
            if(movement.y < 0)
            {
                playerDirection = Direction.SW;
            }else if( movement.y > 0)
            {
                playerDirection = Direction.NW;
            }
            else
            {
                playerDirection = Direction.W;
            }
        }else if(movement.x > 0)
        {
            if (movement.y < 0)
            {
                playerDirection = Direction.SE;
            }
            else if (movement.y > 0)
            {
                playerDirection = Direction.NE;
            }
            else
            {
                playerDirection = Direction.E;
            }
        }
        else
        {
            if (movement.y < 0)
            {
                playerDirection = Direction.S;
            }
            else if (movement.y > 0)
            {
                playerDirection = Direction.N;
            }
            else
            {
                //do nothing
            }
        }
    }

    public void OnNormalAttack(InputAction.CallbackContext context)
    {
        isCastSpell = context.action.triggered;
        Debug.Log(isCastSpell + context.phase.ToString());
    }

    //
    public void DrawLineOfSight()
    {

    }
}
