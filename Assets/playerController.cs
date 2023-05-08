using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playerController : MonoBehaviour
{
    public float moveSpeed = 1f;

    public float collisionOffset = 0.5f;

    public ContactFilter2D movementFilter;
    

    Vector2 movementInput;

    Rigidbody2D rb;

    List<RaycastHit2D> castCollisions = new List <RaycastHit2D>();

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // if movement is not 0, try to move
    private void FixedUpdate()
    {
        if (movementInput != Vector2.zero)
        {
            bool sucess = TryMove(movementInput);
            if (sucess) {
                sucess = TryMove(new Vector2(movementInput.x, 0));


            if (!sucess) {
                    sucess = TryMove(new Vector2(0, movementInput.y));
                        }
            }
        }
    }

    private bool TryMove(Vector2 direction) {
        int count = rb.Cast(direction, movementFilter, castCollisions, moveSpeed * Time.fixedDeltaTime + collisionOffset);
        if (count == 0)
        {
            rb.position = (rb.position + direction * moveSpeed * Time.fixedDeltaTime);
            return true;
        }
        else {
            return false;
        }
    }

    void OnMove(InputValue movementValue) {
        movementInput = movementValue.Get<Vector2>();
    }
}