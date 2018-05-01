using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour {
    //GameObject CloneTest;
    public float distanceFromEnemy;
    Vector3 myPosition;

    // Update is called once per frame
    void Update()
    {

        //Debug.Log(transform.forward);
        //Debug.Log(Vector3.forward);

        var myPositionForDistance = transform.position;
        var myPositionForDirection = transform.forward;
        //Debug.Log("myPositionForDistance: " + myPositionForDistance);
        //Debug.Log("myPositionForDirection: " + myPositionForDirection);


        //For single tag find direction and distance
        if (GameObject.FindGameObjectWithTag("BunnyClone"))
          {
              var distBunnyClone = GameObject.FindGameObjectWithTag("BunnyClone").transform.position;
              var heading = myPositionForDistance - distBunnyClone;
              var distance = heading.magnitude;
            // Debug.Log("Distance from BunnyClone:" + distance);

            if(distance < 10)
            {
                var tempHeading = myPositionForDirection - distBunnyClone;
                var tempDistance = tempHeading.magnitude;
                var tempDirection = tempHeading / tempDistance;
                Debug.Log("Direction of Bunny:"+ tempDirection);
            }

            //var direction = heading / distance;
              //Debug.Log("Direction of BunnyClone:" + direction);
          }

        /* Multiple Bunny Enemies
         * if (GameObject.FindGameObjectsWithTag("BunnyClone") != null)
        {
            var distBunnyCloneArray = GameObject.FindGameObjectsWithTag("BunnyClone");
            foreach (var cloneTest in distBunnyCloneArray)
            {
                //Vector3 cloneDistanceTest = cloneTest.transform.forward;
                var cloneDistanceBunny = cloneTest.transform.position;
                var heading1 = myPosition - cloneDistanceBunny;
                var distance1 = heading1.magnitude;
                Debug.Log("Distance of BunnyClone:" + distance1);

               
                //var direction1 = heading1 / distance1;
                //Debug.Log("Direction of BunnyClone:" + direction1);
            }
        }*/
        if (GameObject.FindGameObjectsWithTag("ZombieClone") != null)
        {
            var distZombieCloneArray = GameObject.FindGameObjectsWithTag("ZombieClone");
            foreach (var cloneTest2 in distZombieCloneArray)
            {
                var cloneDistanceTest2 = cloneTest2.transform.position;
                var heading2 = myPosition - cloneDistanceTest2;
                var distance2 = heading2.magnitude;
                var direction2 = heading2 / distance2;
                //Debug.Log("Distance of ZombieClone:" + distance2);
                Debug.Log("Direction of ZombieClone:" + direction2);
            }
        }
        if (GameObject.FindGameObjectsWithTag("BearClone") != null)
        {
            var distBearCloneArray = GameObject.FindGameObjectsWithTag("BearClone");
            foreach (var cloneTest3 in distBearCloneArray)
            {
                var cloneDistanceTest3 = cloneTest3.transform.position;
                var heading3 = myPosition - cloneDistanceTest3;
                var distance3 = heading3.magnitude;
                var direction3 = heading3 / distance3;
                //Debug.Log("Distance of BearClone:" + distance3);
                Debug.Log("Direction of BearClone:" + direction3);
            }
        }
        if (GameObject.FindGameObjectsWithTag("ElephantClone") != null)
        {
            var distElephantCloneArray = GameObject.FindGameObjectsWithTag("ElephantClone");
            foreach (var cloneTest4 in distElephantCloneArray)
            {
                var cloneDistanceTest4 = cloneTest4.transform.position;
                var heading4 = myPosition - cloneDistanceTest4;
                var distance4 = heading4.magnitude;
                var direction4 = heading4 / distance4;
                //Debug.Log("Distance of ElephantClone:" + distance4);
                
                Debug.Log("Direction of ElephantClone:" + direction4);
            }
        }



    }
    void Start () {
		
	}

    void Awake()
    {
    }
    void OnTriggerEnter(Collider other)
    {
       // Debug.Log("onTriggerEnter in Collision Detection.cs");
        //if (other.gameObject == player)
        //{
        if(other.gameObject == GameObject.FindWithTag("BunnyClone"))
        {
            Debug.Log("onTrigger with CloneTest : Bunny Clone");
        }
        else if (other.gameObject == GameObject.FindWithTag("ZombieClone"))
        {
            Debug.Log("onTrigger with CloneTest : ZombieClone");
        }
        else if (other.gameObject == GameObject.FindWithTag("BearClone"))
        {
            Debug.Log("onTrigger with CloneTest : Bear Clone");
        }
        else if (other.gameObject == GameObject.FindWithTag("ElephantClone"))
        {
            Debug.Log("onTrigger with CloneTest : Elephant Clone");
        }
        // ... the player is in range.
        //playerInRange = true;
        
    }
    
    void OnTriggerExit(Collider other)
    {
        // If the exiting collider is the player...
      //  if (other.gameObject == player)
        //{
            // ... the player is no longer in range.
          //  playerInRange = false;
        //}
    }
}
