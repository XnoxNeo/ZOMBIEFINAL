using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    [Header("Player input stats")]
    public float moveSpeed = 5f;
    public float baseSpeed = 5f;

    [Header("Player stats")]
    public PlayerStats stats;

    public float damageMultiplier;
    private float currentDamageMultiplier;

    private float currentSpeed;

    [SerializeField] private Vector2 moveInput;
    public Vector2 MoveInput => moveInput;

    [Header("Components")]
    private Rigidbody2D rb;
    public Rigidbody2D Rb => rb;

    [SerializeField] private Animator animator;
    [SerializeField] private SpriteRenderer sr;
    private HealthSystem healthSystem;

    public StateMachine stateMachine;

    [Header("Events")]
    [SerializeField] private UnityEvent healthChecker;

    private void Awake()
    {
        stateMachine = new StateMachine(this);
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
        sr = GetComponentInChildren<SpriteRenderer>();  
        healthSystem = GetComponent<HealthSystem>();
        stats = GetComponent<PlayerStats>();
        

        
    }

    private void Start()
    {
        animator.SetBool("Walking", false);
        stateMachine.Initialize(stateMachine.idleState);
        
    }

    private void Update()
    {
        
        moveSpeed = stats.Speed * baseSpeed;
       
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");


        if(stateMachine.CurrentState == stateMachine.walkingState)
        {
            animator.SetBool("Walking", true);
        }
        else
        {
            animator.SetBool("Walking", false);
        }

        stateMachine.Udpate();


        if(healthSystem.CurrentHealth <= 0)
        {
            healthChecker?.Invoke();
        }

        

    }

    private void FixedUpdate()
    {
        
        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);
    }

    

}
