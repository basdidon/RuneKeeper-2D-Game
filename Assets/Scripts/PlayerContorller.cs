using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;


public class PlayerContorller : MonoBehaviour
{
    public enum CharacterState {Idle, Moving, Attacking, CastingSpell, Stun, Dead};
    public enum Direction {N, NW, W, SW, S, SE, E, NE};

    public PlayerControls controls;
    public CharacterState playerState = CharacterState.Idle;
    public Direction playerDirection = Direction.S;
    public Vector3 mousePosition;
    public Vector2 movement;
    public float speed = 10f;
    public Rigidbody2D playerRigidbody;
    public bool isCastSpell;

    public List<Enemy> onSightEnemy = new List<Enemy>();
    public Enemy selectedEnemy;
    

    /*cursor
    //public Texture2D cursorTexture;
    //public CursorMode cursorMode = CursorMode.ForceSoftware;
    //public Vector2 hotSpot = Vector2.zero;
    */

    private void Awake()
    {
        controls = new PlayerControls();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    void Start()
    {
        controls.Player.RightMouseButton.performed += _ => OnRightMouseButtonClick();
        controls.Player.Movement.performed += _ => OnMove();
        controls.Player.Interaction.performed += _ => OnInteraction();
        controls.Player.Attack.performed += _ => OnAttack();

        //Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);
        Debug.Log("Movement : " + controls.Player.Movement.phase);
        Debug.Log("Interaction : " + controls.Player.Interaction.phase);
        Debug.Log("Attack : " + controls.Player.Attack.phase);
    }

    public void OnMove()
    {
        movement = controls.Player.Movement.ReadValue<Vector2>();    
    }

    public void OnInteraction()
    {
        
        Debug.Log("z");
    }

    public void OnAttack()
    {
        if(selectedEnemy != null)
        {
            Debug.Log("Do Attack");
        }
        else
        {
            FindNearestEnemy();
        }
    }

    public void OnCastspell()
    {
        if (selectedEnemy != null)
        {
            Debug.Log("Cast Spell");
        }
        else
        {
            FindNearestEnemy();
        }
    }

    public void OnQuickMove()
    {
        if (selectedEnemy != null || movement == Vector2.zero)
        {
            //dash to facing direction
        }
        else
        {
            //dash to movement direction
        }
    }

    private void FindNearestEnemy()
    {
        int minDistance = 100;
        Enemy selectedEnemy = null;
        for(int i = 0; i < onSightEnemy.Count; i++)
        {
            if (Vector2.Distance(onSightEnemy[i].transform.position, transform.position) < minDistance)
            {
                selectedEnemy = onSightEnemy[i];
            }
        }
        this.selectedEnemy = selectedEnemy;
    }

    //input
    public void OnRightMouseButtonClick()
    {
        mousePosition = controls.Player.MousePosition.ReadValue<Vector2>();
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(mousePosition,Vector3.forward, 500);
        Debug.DrawRay(mousePosition,Vector3.forward*500, Color.red);
        if (hit.collider != null)
        {
            Debug.Log(hit.collider.name);
            if(hit.collider.tag == "Enemy")
            {

            }
        }
        else
        {
            
        }
    }
}
