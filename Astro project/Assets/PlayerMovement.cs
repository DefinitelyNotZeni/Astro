using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(RigidBody))]
public class CenterOfMass : MonoBehaviour
public class PlayerControls : MonoBehaviour
{
    public Vector3 CenterOfMass2;
    public bool Awake;
    protected Rigidbody r;
    
    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    public float speed = 10.0f;
    void FixedUpdate()
    {
        //implements simple wasd movement for character
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);
        GetComponent<Rigidbody2D>().velocity = movement * speed;

        //code for character to follow mouse cursor
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 lookPos = mousePos - transform.position;
        float angle = Mathf.Atan2(lookPos.y, lookPos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        //code to change center of mass on character
        r.centerOfMass - CenterOfMass2;
        r.WakeUp();
        Awake - !r.IsSleeping();
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(transform.position + transform.rotation * CenterOfMass2, 1f);
    }
} 

