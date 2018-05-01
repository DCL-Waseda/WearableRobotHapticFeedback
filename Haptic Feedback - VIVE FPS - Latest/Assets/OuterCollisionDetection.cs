using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OuterCollisionDetection : MonoBehaviour
{
    GameObject CloneTest;
    Collider other2;
    // Use this for initialization
    void Start()
    {
        //Physics.IgnoreCollision(GetComponent<Collider>(), GetComponent<Collider>());
    }

    void Awake()
    {
        //CloneTest = GameObject.FindGameObjectWithTag("clone");
    }
    void OnTriggerEnter(Collider other)
    {
        // If the entering collider is the player...
        // Debug.Log("onTriggerEnter in Collision Detection.cs");
        //if (other.gameObject == player)
        //{


        if (other.gameObject.tag == "BunnyClone")
        {
            Debug.Log("Outer Collider onTrigger with CloneTest : Bunny Clone");
        }
        else if (other.gameObject == GameObject.FindWithTag("Bunny2Clone"))
        {
            Debug.Log("Outer Collider onTrigger with CloneTest : Bunny2Clone");
        }
        else if (other.gameObject == GameObject.FindWithTag("BearClone"))
        {
            Debug.Log("Outer Collider onTrigger with CloneTest : Bear Clone");
        }
        else if (other.gameObject == GameObject.FindWithTag("ElephantClone"))
        {
            Debug.Log("onTrigger with CloneTest : Elephant Clone");
        }

       // Physics.IgnoreCollision(other,other2, true);
        // ... the player is in range.DeathToggle
        //playerInRange = true;
        //OnCollisionEnter();

        //}
    }

   
    /*//Point where the enemy enters the capsule
    void OnCollisionEnter(Collision collision)
    {
        ContactPoint contact = collision.contacts[0];
        Quaternion rot = Quaternion.FromToRotation(Vector3.up, contact.normal);
        Vector3 pos = contact.point;
        //Instantiate(explosionPrefab, pos, rot);
        //Destroy(gameObject);
        Debug.Log("Contact point debug:" + contact.point.x +","+ contact.point.y +","+ contact.point.z);
    }*/

    void OnTriggerExit(Collider other)
    {
        // If the exiting collider is the player...
        //  if (other.gameObject == player)
        //{
        // ... the player is no longer in range.
        //  playerInRange = false;
        //}
    }

    // Update is called once per frame
    void Update()
    {

    }
}
