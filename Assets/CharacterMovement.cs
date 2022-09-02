using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed;
    void Start()
    {
        speed = 5f;
    }

    void Update()
    {
        transform.Translate(speed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, speed * Input.GetAxis("Vertical") * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().freezeRotation = true;
    }
}
