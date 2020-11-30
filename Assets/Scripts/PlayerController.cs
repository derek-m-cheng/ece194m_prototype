using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public float speed = 2.0f;
    Rigidbody2D rigidbody2d;
    public float charger;
    public bool discharge;
    public float jumpForce;

    private void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey (KeyCode.A))
        {
            rigidbody2d.velocity = new Vector2(speed * -1, rigidbody2d.velocity.y);
        }
        if (Input.GetKey (KeyCode.D))
        {
            rigidbody2d.velocity = new Vector2(speed, rigidbody2d.velocity.y);
        }
        // On (discharge == true)
        if (discharge)
        {
            // Set jump force and give new velocity
            jumpForce = 10 * charger;
            rigidbody2d.velocity = new Vector2(rigidbody2d.velocity.x, jumpForce);

            // Reset discharge and charger values
            discharge = false;
            charger = 0f;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            charger += UnityEngine.Time.deltaTime;
        }

        // On release, set the boolean 'discharge' to true.
        if (Input.GetKeyUp(KeyCode.Space))
        {
            discharge = true;
        }
    }
}
