using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody myRigidBody;

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
        myRigidBody.velocity = new Vector3(3, -6, 0);
    }

    // Update is called once per frame
    void Update()
    {
       // float speed = 9;
        //myRigidBody.velocity = myRigidBody.velocity.normalized * speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            myRigidBody.velocity = new Vector3(myRigidBody.velocity.x, myRigidBody.velocity.y * -1, myRigidBody.velocity.z);
        }
        if (other.tag == "Wall")
        {
            myRigidBody.velocity = new Vector3(myRigidBody.velocity.x * -1, myRigidBody.velocity.y, myRigidBody.velocity.z);
        }
        if (other.tag == "blox")
        {
            myRigidBody.velocity = new Vector3(myRigidBody.velocity.x, myRigidBody.velocity.y * -1, myRigidBody.velocity.z);
            Destroy(other.gameObject);
        }
        if (other.tag == "tak")
        {
            myRigidBody.velocity = new Vector3(myRigidBody.velocity.x, myRigidBody.velocity.y * -1, myRigidBody.velocity.z);
        }
    }
}
