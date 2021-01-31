using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    public float speed = 10.0f;
    public float turnSpeed = 50.0f;
    public GameObject arrow;
    private float _canFire = -1f;
    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        UpdateMovement();

        if (Input.GetButtonDown("Fire1") && Time.time > _canFire)
        {
           ShootArrow();
        }

    }

    void UpdateMovement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
    }

    void ShootArrow()
    {
        
        Instantiate(arrow, transform.position + new Vector3(0, 1, 3) + transform.forward, Quaternion.identity);
    }
    
}
