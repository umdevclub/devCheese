using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    // Adjusts the speed of the mouse, we can edit this in Unity Inspector
    [SerializeField] private float speed;

    // Input Action Asset to handle our input actions
    [SerializeField] private InputActionAsset inputActions;

    // Input Action for movement
    private InputAction moveAction;

    // Responsible for our movement
    // To access our RigidBody2D Component, we need a variable to store it
    // Same idea with classes and objects as per most COMP Courses
    private Rigidbody2D rb;

    // A 2D Vector we will use to manipulate movement
    private Vector2 movementDirection;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // To initialize rb, we can actually access our component RigidBody2D like so
        // Remember we are NOT making a new object, we are only accessing the one we made awhile ago
        rb = GetComponent<Rigidbody2D>();

        // Initialize our moveAction by finding it from the Input Action Asset
        moveAction = inputActions.FindActionMap("Player").FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {
        // moves our 2d vector depending on how much we hold WASD or the arrow keys
        movementDirection = moveAction.ReadValue<Vector2>();

    }

    // FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        // manipulates the direction of our mouse with regards to speed
        // rb.linearVelocity = movementDirection * speed;

        // manipulates the position of our mouse with regards to speed, but differenltly ?
        rb.MovePosition(rb.position + movementDirection * speed * Time.fixedDeltaTime);
    }

    // Enable the input action map when the object is enabled
    void OnEnable()
    {
        inputActions.FindActionMap("Player").Enable();
    }

    // Disable the input action map when the object is disabled/destroyed
    void OnDisable()
    {
        inputActions.FindActionMap("Player").Disable();
    }
}
