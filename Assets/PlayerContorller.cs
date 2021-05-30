using UnityEngine;
using UnityEngine.InputSystem;

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

    //cursor
    //public Texture2D cursorTexture;
    //public CursorMode cursorMode = CursorMode.ForceSoftware;
    //public Vector2 hotSpot = Vector2.zero;

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

        //Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        playerRigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);
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
    }
}
