using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpStrength;
    public float moveSpeed;
    public GameObject projectile;
    public LogicScript logic;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Counter").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) == true)
        {
            rb.linearVelocityX = moveSpeed;
        }

        if (Input.GetKey(KeyCode.A) == true)
        {
            rb.linearVelocityX = -moveSpeed;
        }

        if (Input.GetKeyDown(KeyCode.W) == true)
        {
            rb.linearVelocity = Vector2.up * jumpStrength;
        }

        if (Input.GetKeyDown(KeyCode.S) == true)
        {
            rb.linearVelocity = Vector2.down * jumpStrength;
        }

        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            FireProjectile();
        }


    }

    private void FireProjectile()
    {
        Instantiate(projectile, new Vector2(transform.position.x + 1, transform.position.y), transform.rotation);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        Destroy(gameObject);
    }
}
