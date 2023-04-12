using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCube : MonoBehaviour
{
    public float moveSpeed;
    void Start()
    {
        
    }

    void Update()
    {
        Move();
    }
    void Move()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        transform.position += movement * moveSpeed * Time.deltaTime;
    }
}
