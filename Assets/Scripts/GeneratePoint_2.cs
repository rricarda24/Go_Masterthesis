using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneratePoint_2 : MonoBehaviour {

    // Objects to be generated // Drag and drop to inspector
    public GameObject sphere;
    public GameObject square;
   
    GameObject sphereInstance;  // Instance of object (sphere and square) 

    public int numberOfSpheres; // Defines how many objects are generated at a time.
    private float minX, maxX, minY, maxY, minZ, maxZ;  // Defines where the objects are placed (here walls specs)

    float distroyAfterSeconds = 1.0f; // Defines how long the instance stays.
    float nextInstanceSeconds = 2.0f; // Defines the intervall until next instance is created.
    float beforeStartSeconds = 2.0f; // Defines time before first instance. 

    float timer; //counts time
    float duration = 30.0f; //task duration

    int countTargets;

    float startTime;
    float reactionTime = 999;
    bool measureReactionTime = false; //set to true if target is shown

    int detectedTargets = 0;
    int errors = 0; //is detected when the next object is instantiate. Problem, if the last one was a square it is missing. 
  
   
    private void Start()
    {
        startInstantiating();
    }

    private void Update()
    {
        TaskDuration();
        if (measureReactionTime == true)// true when target is shown
        {
            OVRInput.Update();
            ReactionTime();
        }
    }

    // to be called in Update
    public void ReactionTime()
    {
        if (OVRInput.Get(OVRInput.Button.One)) //if (Input.GetButtonDown("Fire1")) // VR: UnityEngine.Input "Button.One" 
        {
            print("round button pressed");
            reactionTime = Time.time - startTime;
            Debug.Log(reactionTime);
            detectedTargets++;
            measureReactionTime = false;
            Debug.Log(measureReactionTime);
        }
    }

    // to be called in Update()
    public void TaskDuration()
    {
        timer += Time.deltaTime;
        //Debug.Log(timer);
        if (timer > duration)
        {
            CancelInvoke("displayTarget");
            if(measureReactionTime == true)
            {
                reactionTime = 999;
                errors++;
                measureReactionTime = false;
            }
            print("Summary - Targets displayed:" + countTargets + " Targets detected: " 
                + detectedTargets + " Errors: " + errors);
        }
    }

    // to be called in Start();
    public void startInstantiating()
    {
        InvokeRepeating("displayTarget", beforeStartSeconds, nextInstanceSeconds);
    }

///////////////////////////////////////////////////////////////////////////////////////////
///Display spheres and squares (=target) randomly. 

    public void displayTarget()
    {
        int random1 = Random.Range(0, 5); // probability to show target: 1/4

        if (random1 == 0) // currently not within range
        {
            if (measureReactionTime == true)
            {
                reactionTime = 999;
                Debug.Log(reactionTime);
                errors++;
                measureReactionTime = false;  //ReactionTime() is disabled when the next sphere is instantiated.
                Debug.Log(measureReactionTime);
            }
           
            int number = Random.Range(0, 4);
            //Debug.Log("Methode Nr." + random1);

            if (number == 0)
                PlaceSphereBack();
            if (number == 1)
                PlaceSphereLeft();
            if (number == 2)
                PlaceSphereRight();
            //if (number == 3)
            //    PlaceSphereCeiling();
            //if (number == 4)
            //    PlaceSphereFloor();
        }

        if (random1 == 1)
        {
            if (measureReactionTime == true)
            {
                reactionTime = 999;
                Debug.Log(reactionTime);
                errors++;
                measureReactionTime = false;
                Debug.Log(measureReactionTime);
            }
            
            int number = Random.Range(0, 4);
            //Debug.Log("Methode Nr." + random1);

            if (number == 0)
                PlaceSphereBack();
            if (number == 1)
                PlaceSphereLeft();
            if (number == 2)
                PlaceSphereRight();
            //if (number == 3)
            //    PlaceSphereCeiling();
            //if (number == 4)
            //    PlaceSphereFloor();
        }

        if (random1 == 2)
        {
            if (measureReactionTime == true)
            {
                reactionTime = 999;
                Debug.Log(reactionTime);
                errors++;
                measureReactionTime = false;
                Debug.Log(measureReactionTime);
            }
            
            int number = Random.Range(0, 4);
            //Debug.Log("Methode Nr." + random1);

            if (number == 0)
                PlaceSphereBack();
            if (number == 1)
                PlaceSphereLeft();
            if (number == 2)
                PlaceSphereRight();
            //if (number == 3)
            //    PlaceSphereCeiling();
            //if (number == 4)
            //    PlaceSphereFloor();
        }

        if (random1 == 3)
        {
            if (measureReactionTime == true)
            {
                reactionTime = 999;
                Debug.Log(reactionTime);
                errors++;
                measureReactionTime = false;
                Debug.Log(measureReactionTime);
            }

            int number = Random.Range(0, 4);
            //Debug.Log("Methode Nr." + random1);

            if (number == 0)
                PlaceSphereBack();
            if (number == 1)
                PlaceSphereLeft();
            if (number == 2)
                PlaceSphereRight();
            //if (number == 3)
            //    PlaceSphereCeiling();
            //if (number == 4)
            //    PlaceSphereFloor();
        }

        if (random1 == 4)
        {
            if (measureReactionTime == true)
            {
                reactionTime = 999;
                Debug.Log(reactionTime);
                errors++;
                measureReactionTime = false;
                Debug.Log(measureReactionTime);
            }

            measureReactionTime = true;

            //Debug.Log("!Square! Methode Nr." + random1);

            countTargets = countTargets + 1;
            //Debug.Log(countTargets);

            int number = Random.Range(0, 4);
            if (number == 0)
                PlaceSquareBack();
            if (number == 1)
                PlaceSquareLeft();
            if (number == 2)
                PlaceSquareRight();
            //if (number == 3)
            //    PlaceSquareCeiling();
            //if (number == 4)
            //    PlaceSquareFloor();

            startTime = Time.time;
            //print(startTime);   
        }
    }

   
/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Generate Position Methods

    // Point on back wall
    Vector3 GeneratedPositionBack()
    {
        float x, y, z;
        minX = -2.5f;
        maxX = 2.5f;
        minY = 0.9f;
        maxY = 3.5f;
        x = UnityEngine.Random.Range(minX, maxX);
        y = UnityEngine.Random.Range(minY, maxY);
        z = 1.5f;
        return new Vector3(x, y, z);
    }

    // Point on left wall
    Vector3 GeneratedPositionLeft()
    {
        float x, y, z;
        minY = 1.3f;
        maxY = 3.0f;
        minZ = -2.5f;
        maxZ = -0.39f;
        x = -1.84f;
        y = UnityEngine.Random.Range(minY, maxY);
        z = UnityEngine.Random.Range(minZ, maxZ);
        return new Vector3(x, y, z);
    }

    // Point on right wall
    Vector3 GeneratedPositionRight()
    {
        float x, y, z;
        minY = 1.1f;
        maxY = 3.2f;
        minZ = -2.3f;
        maxZ = 0.1f;
        x = 2.188f;
        y = UnityEngine.Random.Range(minY, maxY);
        z = UnityEngine.Random.Range(minZ, maxZ);
        return new Vector3(x, y, z);
    }

    // Point on ceiling
    //Vector3 GeneratedPositionCeiling()
    //{
    //    float x, y, z;
    //    minX = -2.64f;
    //    maxX =2.6f;
    //    minZ = -0.15f;
    //    maxZ = 1.39f;
    //    x = UnityEngine.Random.Range(minX, maxX);
    //    y = 3.7f;
    //    z = UnityEngine.Random.Range(minZ, maxZ);
    //    return new Vector3(x, y, z);
    //}

    // Point on floor
    //Vector3 GeneratedPositionFloor()
    //{
    //    float x, y, z;
    //    minX = -2.64f;
    //    maxX = 2.6f;
    //    minZ = -0.15f;
    //    maxZ = 1.35f;
    //    x = UnityEngine.Random.Range(minX, maxX);
    //    y = 0.52f;
    //    z = UnityEngine.Random.Range(minZ, maxZ);
    //    return new Vector3(x, y, z);
    //}
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // Place square and spheres methods

    public void PlaceSquareBack()
    {
        var rotation = new Quaternion();
        rotation.eulerAngles = new Vector3(0, 0, 0);
        for (int i = 0; i < numberOfSpheres; i++)
        {
            sphereInstance = Instantiate(square, GeneratedPositionBack(), rotation);
        }
        Destroy(sphereInstance, distroyAfterSeconds);
    }

    void PlaceSquareLeft()
    {
        var rotation = new Quaternion();
        rotation.eulerAngles = new Vector3(0, 90, 0);
        for (int i = 0; i < numberOfSpheres; i++)
        {
            sphereInstance = Instantiate(square, GeneratedPositionLeft(), rotation);
        }
        Destroy(sphereInstance, distroyAfterSeconds);
    }

    void PlaceSquareRight()
    {
        var rotation = new Quaternion();
        rotation.eulerAngles = new Vector3(0, -90, 0);
        for (int i = 0; i < numberOfSpheres; i++)
        {
            sphereInstance = Instantiate(square, GeneratedPositionRight(), rotation);
        }
        Destroy(sphereInstance, distroyAfterSeconds);
    }

    //void PlaceSquareCeiling()
    //{
    //    var rotation = new Quaternion();
    //    rotation.eulerAngles = new Vector3(-90, 0, 0);
    //    for (int i = 0; i < numberOfSpheres; i++)
    //    {
    //        sphereInstance = Instantiate(square, GeneratedPositionCeiling(), rotation);
    //    }
    //    Destroy(sphereInstance, distroyAfterSeconds);
    //}

    //void PlaceSquareFloor()
    //{
    //    var rotation = new Quaternion();
    //    rotation.eulerAngles = new Vector3(-90, 0, 0);
    //    for (int i = 0; i < numberOfSpheres; i++)
    //    {
    //        sphereInstance = Instantiate(square, GeneratedPositionFloor(), rotation);
    //    }
    //    Destroy(sphereInstance, distroyAfterSeconds);
    //}

    void PlaceSphereBack()
    {
        var rotation = new Quaternion();
        rotation.eulerAngles = new Vector3(0, 0, 0);
        for (int i = 0; i < numberOfSpheres; i++)
        {
            sphereInstance = Instantiate(sphere, GeneratedPositionBack(), rotation);
        }
        Destroy(sphereInstance, distroyAfterSeconds);
    }

    void PlaceSphereLeft()
    {
        var rotation = new Quaternion();
        rotation.eulerAngles = new Vector3(0, 90, 0);
        for (int i = 0; i < numberOfSpheres; i++)
        {
            sphereInstance = Instantiate(sphere, GeneratedPositionLeft(), rotation);
        }
        Destroy(sphereInstance, distroyAfterSeconds);
    }

    void PlaceSphereRight()
    {
        var rotation = new Quaternion();
        rotation.eulerAngles = new Vector3(0, -90, 0);
        for (int i = 0; i < numberOfSpheres; i++)
        {
            sphereInstance = Instantiate(sphere, GeneratedPositionRight(), rotation);
        }
        Destroy(sphereInstance, distroyAfterSeconds);
    }

    //void PlaceSphereCeiling()
    //{
    //    var rotation = new Quaternion();
    //    rotation.eulerAngles = new Vector3(-90, 0, 0);
    //    for (int i = 0; i < numberOfSpheres; i++)
    //    {
    //        sphereInstance = Instantiate(sphere, GeneratedPositionCeiling(), rotation);
    //    }
    //    Destroy(sphereInstance, distroyAfterSeconds);
    //}

    //void PlaceSphereFloor()
    //{
    //    var rotation = new Quaternion();
    //    rotation.eulerAngles = new Vector3(-90, 0, 0);
    //    for (int i = 0; i < numberOfSpheres; i++)
    //    {
    //        sphereInstance = Instantiate(sphere, GeneratedPositionFloor(), rotation);
    //    }
    //    Destroy(sphereInstance, distroyAfterSeconds);
    //}
}
