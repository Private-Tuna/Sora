using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    
    private Rigidbody rb;
    private float torque;
    [SerializeField] float speed = 1f;
    [SerializeField] float eulerAngX;
    [SerializeField] float eulerAngY;
    [SerializeField] float eulerAngZ;

    // Start is called before the first frame update
    void Start(){
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate() {
        eulerAngX = this.transform.localEulerAngles.x;
        eulerAngY = this.transform.localEulerAngles.y;
        eulerAngZ = this.transform.localEulerAngles.z;
      
        /*
        //Movement, based on camera platform rotates right for d, left for s, forward w, back s. clamps not working right now idk why
        if (Input.GetKey(KeyCode.D) && eulerAngZ > -20)
        {
            this.transform.Rotate(Vector3.back * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A) && eulerAngZ < 20) {
            this.transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.W) && eulerAngX < 20)
        {
            this.transform.Rotate(Vector3.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S) && eulerAngX > -20)
        {
            this.transform.Rotate(Vector3.left * speed * Time.deltaTime);
        }
        */
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Rotate(Vector3.back * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            this.transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            this.transform.Rotate(Vector3.right * speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            this.transform.Rotate(Vector3.left * speed * Time.deltaTime);
        }
    }
    
}
