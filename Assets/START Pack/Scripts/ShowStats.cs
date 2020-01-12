using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class ShowStats : MonoBehaviour
{
    private Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody> ();
    }

    // Update is called once per frame
    void Update()
    {
      Debug.Log(name + " interia tmensor " +rigidBody.inertiaTensor);
      Debug.Log("center of mass " + rigidBody.centerOfMass);
    }
}
