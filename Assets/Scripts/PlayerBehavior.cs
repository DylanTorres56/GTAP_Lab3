using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    public Rigidbody2D rb;
    public float movementSpeed;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        float moveDirection = Input.GetAxis("Horizontal");
        rb.MovePosition(new Vector2(this.transform.position.x + moveDirection * Time.fixedDeltaTime * movementSpeed, this.transform.position.y));
    }
}
