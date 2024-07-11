using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField] private float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 input = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            input.z += 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            input.z -= 1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            input.x -= 1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            input.x += 1;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            input.y += 1;
        }

        transform.position += input * (movementSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sphere"))
        {
            Destroy(other.gameObject);
        }
    }

}
