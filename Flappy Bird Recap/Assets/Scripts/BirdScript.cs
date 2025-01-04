using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D birdRigidBody;
    public Collider2D birdCollider;
    public Animator birdAnimator;

    public float flapStrength;
    public float fallSpeed;
    public float deathGravity = -5;
    public bool birdIsAlive = true;

    public LogicScript logic;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {   
        birdRigidBody.gravityScale = fallSpeed;
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
        birdAnimator.SetBool("isAlive", true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            birdRigidBody.linearVelocity = Vector2.up * flapStrength;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        birdRigidBody.linearVelocity = Vector2.zero;
        birdRigidBody.gravityScale = deathGravity;
        logic.gameOver();
        birdCollider.enabled = false;
        birdIsAlive = false;
        birdAnimator.SetBool("isAlive", false);

        // Set Z pos to -2 to make the bird appear above the logs
        Vector3 newPosition = transform.position;
        newPosition.z = -2;
        transform.position = newPosition;
    }
}
