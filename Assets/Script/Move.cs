using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Move : MonoBehaviour
{
    public float movementSpeed = 6f;
    public float lastMousePos;
    public float swerve;
    public float swerveSpeed = 3f;
    [HideInInspector]  public Rigidbody rb;
    public bool isMove = true;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        if (isMove)
        {
            if (Input.GetMouseButtonDown(0))
            {
                lastMousePos = Input.mousePosition.x;
            }
            else if (Input.GetMouseButton(0))
            {
                swerve = (Input.mousePosition.x - lastMousePos);
                lastMousePos = Input.mousePosition.x;
            }
            else if (Input.GetMouseButtonUp(0))
            {
                swerve = 0;
            }
        }
    }
    private void FixedUpdate()
    {
        if (isMove)
        {
            float swerveAmount = swerveSpeed * swerve;
            rb.velocity = (new Vector3(swerveAmount, 0, movementSpeed));
            if (transform.position.x > 3.6f)
            {
                transform.position = new Vector3(3.6f, transform.position.y, transform.position.z);
            }
            else if (transform.position.x < -3.6f)
            {
                transform.position = new Vector3(-3.6f, transform.position.y, transform.position.z);
            }
        }
    }
}
