using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    public float moveSpeed = 1f;

    public float collisionOffset = 0.5f;

    public ContactFilter2D movementFilter;

    private Inventory inventory;

    [SerializeField] private UI_Inventory uiInventory;

    Vector2 movementInput;

    Animator animator;

    SpriteRenderer spriteRenderer;

    Rigidbody2D rb;

    List<RaycastHit2D> castCollisions = new List <RaycastHit2D>();

    bool canMove = true;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        inventory = new Inventory();
        uiInventory.SetInventory(inventory);

        ItemWorld.SpawnItemWorld(new Vector3(20, 20), new Item { itemType = Item.ItemType.Chest, amount = 1 });


        
    }

    // if movement is not 0, try to move
    private void FixedUpdate()
    {
        if (canMove)
        {
            if (movementInput != Vector2.zero)
            {
                bool sucess = TryMove(movementInput);
                if (sucess && movementInput.x != 0)
                {
                    sucess = TryMove(new Vector2(movementInput.x, 0));

                }
                if (!sucess && movementInput.y != 0)
                {
                    sucess = TryMove(new Vector2(0, movementInput.y));
                }
                animator.SetBool("isMoving", sucess);
            }
            else
            {
                animator.SetBool("isMoving", false);
            }
            if (movementInput.x < 0)
            {
                spriteRenderer.flipX = true;
            }
            else if (movementInput.x > 0)
            {
                spriteRenderer.flipX = false;
            }
        }
    }

    private bool TryMove(Vector2 direction)
    {
        if (direction != Vector2.zero)
        {
            int count = rb.Cast(direction, movementFilter, castCollisions, moveSpeed * Time.fixedDeltaTime + collisionOffset);
            if (count == 0)
            {
                rb.position = (rb.position + direction * moveSpeed * Time.fixedDeltaTime);
                return true;
            }
            else
            {
                return false;
            }
        }
        else {
            return false;
        }
    }

    void OnMove(InputValue movementValue) {
        movementInput = movementValue.Get<Vector2>();
    }

    void OnPickUp()
    {
        print("pickup pressed");
        animator.SetTrigger("blockUp");

    }

    void OnPlace() {
        print("place pressed");
        animator.SetTrigger("blockDown");
    }

    public void LockedMovement() {
        canMove = false;
    }

    public void UnlockMovement() {
        canMove = true;
    }
}
