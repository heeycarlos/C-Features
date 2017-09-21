using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clean up code: CTRL+K+D
namespace Variables
{
    public class Movement : MonoBehaviour
    {
        public float movementSpeed = 20f;
        public float rotationSpeed = 20f;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            // Check IF user presses W
            if (Input.GetKey(KeyCode.W))
            {
                // Move up
                transform.Translate(new Vector3(0, movementSpeed, 0) * Time.deltaTime);
            }
            // Check IF user presses S
            if (Input.GetKey(KeyCode.S))
            {
                // Move down
                transform.Translate(new Vector3(0, -movementSpeed, 0) * Time.deltaTime);
            }
            // Check IF user presses A
            if (Input.GetKey(KeyCode.A))
            {
                // Move left
                transform.Translate(new Vector3(-movementSpeed, 0, 0) * Time.deltaTime);
            }
            // Check IF user presses D
            if (Input.GetKey(KeyCode.D))
            {
                // Move right
                transform.Translate(new Vector3(movementSpeed, 0, 0) * Time.deltaTime);
            }
        }
    }
}