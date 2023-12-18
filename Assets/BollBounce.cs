using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BollBounce : MonoBehaviour
{
    Rigidbody myRigidBody;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
        myRigidBody.velocity = new Vector3(Random.Range(-1,-1), -2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 9;
        myRigidBody.velocity = myRigidBody.velocity.normalized * speed;
        if(transform.position.y < -5 )
        {
            transform.position = new Vector3(0, 3, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += new Vector3(0, -2, 0) * Time.deltaTime;
        }
    }
    

}
