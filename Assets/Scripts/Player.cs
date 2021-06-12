using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;
using System.Collections.Generic;


public class Player : MonoBehaviour
{    
    [Header("PlayerStat")]
    #region PlayerStat

    public float atk;
    public float matk;
    public float maxHp;
    public float hpLeft;
    public float maxMp;
    public float mpLeft;
    #endregion

    public enum CharacterState {Idle, Moving, Attacking, CastingSpell, Stun, Dead};

    public PlayerControls controls;
    public CharacterState playerState = CharacterState.Idle;
    
    public Vector2 direction = new Vector2(1,0);

    public bool isDebug;

    public Vector3 mousePosition;
    public Vector2 movement;

    public float speed = 5f;
    private Rigidbody2D playerRigidbody;
    public bool isCastSpell;

    public List<Enemy> onSightEnemy = new List<Enemy>();
    public Enemy selectedEnemy;
    public GameObject crosshair;
    public GameObject clone;

    public int index;

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
        controls.Player.DebugButton.performed += _ => OnDebugButton();

        //Cursor.SetCursor(cursorTexture, hotSpot, cursorMode);
        playerRigidbody = GetComponent<Rigidbody2D>();

        hpLeft = maxHp;
        mpLeft = maxMp;
    }

    private void Update()
    {

    }

    private void FixedUpdate()
    {
        if (isDebug)
        {
            Debug.Log("Movement : " + controls.Player.Movement.phase);
            Debug.Log("Interaction : " + controls.Player.Interaction.phase);
            Debug.Log("Attack : " + controls.Player.Attack.phase);
        }

        if(selectedEnemy != null)
        {
            direction = (selectedEnemy.transform.position - transform.position).normalized;
        }
        else if (movement != Vector2.zero)
        {
            direction = movement.normalized;
        }

        Debug.DrawRay(transform.position, direction, Color.yellow);
        playerRigidbody.velocity = movement * speed;
    }

    public void OnMove()
    {
        movement = controls.Player.Movement.ReadValue<Vector2>();
    }

    public void OnInteraction()
    {
        ChangeTarget(true);
        //Debug.Log("z");
    }

    public virtual void OnAttack()
    {
        if(selectedEnemy == null){ FindNearestEnemy();}
        //Debug.Log("Do Attack");

    }

    public virtual void OnCastspell()
    {
        if (selectedEnemy != null) { FindNearestEnemy();}
        //Debug.Log("Cast Spell");
    }

    public void OnQuickMove()
    {
        if (movement != Vector2.zero)
        {
            //dash to movement direction
        }
        else
        {
            if (selectedEnemy != null)
            {
                //dash to backward
            }
            else
            {
                //dash to forward
            }
        }
    }

    private void FindNearestEnemy()
    {
        float minDistance = 100;
        Enemy selectedEnemy = null;

        if (onSightEnemy.Count > 0)
        {
            for(int i = 0; i < onSightEnemy.Count; i++)
            {
                if (Vector2.Distance(onSightEnemy[i].transform.position, transform.position) < minDistance)
                {
                    selectedEnemy = onSightEnemy[i];
                    minDistance = Vector2.Distance(onSightEnemy[i].transform.position, transform.position);
                }
            }
            this.selectedEnemy = selectedEnemy;
            clone = Instantiate<GameObject>(crosshair, selectedEnemy.transform);
        }
        else
        {
            Debug.Log("No enemy in range");
        }
    }

    public void ChangeTarget(bool isNextTarget)
    {
        if(selectedEnemy != null)
        {
            for (int i = 0; i < onSightEnemy.Count; i++)
            {
                if (selectedEnemy == onSightEnemy[i])
                {
                    if (isNextTarget)
                    {
                        if (i < onSightEnemy.Count-1)
                        {
                            selectedEnemy = onSightEnemy[i + 1];
                            break;
                        }
                        else
                        {
                            selectedEnemy = onSightEnemy[0];
                            break;
                        }
                    }
                    else
                    {
                        if (i > 0)
                        {
                            selectedEnemy = onSightEnemy[i - 1];
                            break;
                        }
                        else
                        {
                            selectedEnemy = onSightEnemy[onSightEnemy.Count - 1];
                            break;
                        }
                    }
                }
            }
            clone.transform.parent = selectedEnemy.transform;
            clone.transform.localPosition = Vector2.zero;
        }
        else
        {
            FindNearestEnemy();
        }
    }

    public void OnDebugButton()
    {
        selectedEnemy.DealDamage(10);
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
