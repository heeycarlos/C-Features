using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Functions
{
    public class Rigid2DMovement : MonoBehaviour
    {
        public float dashSpeed = 5f;
        public float rotationSpeed = 5f;
        public float acceleration = 20f;
        public float deceleration = 0.1f;

        private Rigidbody2D rigid2D;

        // Use this for initialization
        void Start()
        {
            rigid2D = GetComponent<Rigidbody2D>();
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Dash();
            }
            Accelerate();
            Decelerate();
            Rotate();
        }

        void Accelerate()
        {
            float inputV = Input.GetAxis("Vertical");
            rigid2D.AddForce(inputV * transform.up * acceleration);
        }

        void Decelerate()
        {
            rigid2D.velocity += -rigid2D.velocity * deceleration;
        }

        void Rotate()
        {
            float inputH = Input.GetAxis("Horizontal");
            transform.Rotate(Vector3.forward, -inputH * rotationSpeed);
        }

        void Dash()
        {
            rigid2D.AddForce(transform.up * dashSpeed, ForceMode2D.Impulse);
        }
    }
}