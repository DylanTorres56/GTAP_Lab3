using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehavior : MonoBehaviour
{
    public Transform player;
    Rigidbody2D rb;
    [SerializeField]
    float speed,speedVariablility,desiredDistance,distanceVariability;
    public enum MoveDirection 
    {
        Clockwise=0,
        Counterclockwise=1
    }
    [SerializeField]
    MoveDirection moveDirection;
    private void Awake()
    {
        moveDirection = (MoveDirection)Random.Range(0, 2);
        rb = GetComponent<Rigidbody2D>();
        speed += Random.Range(-speedVariablility, speedVariablility);
        desiredDistance += Random.Range(-distanceVariability, distanceVariability);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }

    private void FixedUpdate()
    {
        Vector2 targetDir = player.position - this.transform.position;
        this.transform.rotation = Quaternion.LookRotation(Vector3.forward, targetDir);
        rb.velocity = this.transform.right * speed* (moveDirection == MoveDirection.Clockwise ? -1 : 1);
        rb.AddForce(-(desiredDistance - targetDir.magnitude) * this.transform.up*20);
    }
}
