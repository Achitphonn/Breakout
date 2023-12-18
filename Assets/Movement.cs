using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

    Rigidbody MyRigidBody;

   public void Start()
    {
        MyRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.A))
        {
            MyRigidBody.velocity = (new Vector3(-6, 0, 0));
        }
        else if (Input.GetKey(KeyCode.D))
        {
            MyRigidBody.velocity = (new Vector3(6, 0, 0));
        }
        else
        {
            MyRigidBody.velocity = (new Vector3(0, 0, 0));

        }

    }
}
