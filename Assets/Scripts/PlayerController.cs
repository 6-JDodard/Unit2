using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float horizontalInput;
    public float speed = 10.0f;
    void Update()
    {
        horizontalInput = horizontalInput.GetAxis("Horizontal")
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
