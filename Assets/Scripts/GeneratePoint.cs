using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.SceneManagement;
using System.IO;

public class GeneratePoint : MonoBehaviour {

    // Objects to be generated // Drag and drop to inspector
    public GameObject sphere;
    public GameObject square;

    public static bool isTarget;
    public static float timeInstantiating;

    GameObject sphereInstance;  // Instance of object (sphere and square) 

    private int numberOfSpheres = 1; // Defines how many objects are generated at a time.
    private float minX, maxX, minY, maxY, minZ, maxZ;  // Defines where the objects are placed (here walls specs)

    float distroyAfterSeconds = 1.0f; // Defines how long the instance stays.
    float nextInstanceSeconds = 2.0f; // Defines the intervall until next instance is created.
    float beforeStartSeconds = 2.0f; // Defines time before first instance. 

    float timer; //counts time
    float duration = 180.0f; //task duration

    int countTargets;

    public static float startTime;

    float reactionTime = 999;
    bool measureReactionTime = false; //set to true if target is shown
    string reactionTimeString;

    int detectedTargets = 0;
    int errors = 0; //is detected when the next object is instantiate. Problem, if the last one was a square it is missing. 

    public string nextScene;

    private void Start()
    {
        StartInstantiating();
    }

    private void Update()
    {
        TaskDuration();
        /*if (measureReactionTime == true)// true when target is shown
        {
            OVRInput.Update();
            ReactionTime();
        }*/
    }


    // to be called in Update
    /*public void ReactionTime()
    {
        if (Input.GetButtonDown("Fire1") || OVRInput.Get(OVRInput.Button.PrimaryIndexTrigger))
        // OVR Manager Script needed!
        // Fire1: Left Ctrl
        // Fire2: Left alt
        {
            print("target detected");
            reactionTime = Time.time - startTime;
            Debug.Log(reactionTime);

            //add reaction time to file
            reactionTimeString = "," + reactionTime.ToString();
            //pathCog = "Assets/CSV/15_cog.csv";
            File.AppendAllText(CreateCSV.pathCog, reactionTimeString);
            //File.AppendAllText(pathCog, reactionTimeString);

            detectedTargets++;

            measureReactionTime = false;
            //Debug.Log(measureReactionTime);
        }
    }*/

    // to be called in Update()
    public void TaskDuration()
    {
        timer += Time.deltaTime;
        Debug.Log(timer);
        if (timer > duration)
        {
            CancelInvoke("displayTarget");
            SceneManager.LoadSceneAsync(nextScene);    
        }
    }

    // to be called in Start();
    public void StartInstantiating()
    {
        {
            InvokeRepeating("DisplayTarget", beforeStartSeconds, nextInstanceSeconds);
            //Debug.Log("Task started.");
        }
    }

    ///////////////////////////////////////////////////////////////////////////////////////////
    ///Display spheres and squares (=target) randomly. 

    public void DisplayTarget()
    {
        int random1 = Random.Range(0, 5); // probability to show target: 1/4

        if (random1 == 0) // currently not within range
        {
            Debug.Log("Within range anyway.");
            // Place distractor
            PlaceSphereBack();
        }

        if (random1 == 1)
        {
            // Place distractor
            PlaceSphereBack();
        }

        if (random1 == 2)
        {
            // Place distractor
            PlaceSphereBack();
        }

        if (random1 == 3)
        {
            // Place distractor
            PlaceSphereBack();
        }

        if (random1 == 4)
        {
            //Place Target
            PlaceSquareBack();
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
        minY = 1.5f;
        maxY = 3.5f;
        x = UnityEngine.Random.Range(minX, maxX);
        y = UnityEngine.Random.Range(minY, maxY);
        z = 1.5f;
        return new Vector3(x, y, z);
    }

    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // Place square and spheres methods
    public void PlaceSquareBack()
    {
        if(isTarget==true && LogCogTask.buttonTime < timeInstantiating)
        {
            Debug.Log("Missed target."); //Add line to file

            string newLine = CreateCSV.ID + "," + SceneCount.sceneCount + ","
                    + "999" + "," + timeInstantiating + ","
                    + isTarget + "," + "999"
                    + System.Environment.NewLine;

            StreamWriter writer = new StreamWriter(CreateCSV.pathCog, true);
            writer.Dispose();

            File.AppendAllText(CreateCSV.pathCog, newLine);

            isTarget = true;
            timeInstantiating = Time.time;
            Debug.Log("Target instantiated: " + timeInstantiating);

            var rotation = new Quaternion();
            rotation.eulerAngles = new Vector3(0, 0, 0);
            for (int i = 0; i < numberOfSpheres; i++)
            {
                sphereInstance = Instantiate(square, GeneratedPositionBack(), rotation);
            }
            Destroy(sphereInstance, distroyAfterSeconds);
        }

        else
        {
            isTarget = true;
            timeInstantiating = Time.time;
            Debug.Log("Target instantiated: " + timeInstantiating);

            var rotation = new Quaternion();
            rotation.eulerAngles = new Vector3(0, 0, 0);
            for (int i = 0; i < numberOfSpheres; i++)
            {
                sphereInstance = Instantiate(square, GeneratedPositionBack(), rotation);
            }
            Destroy(sphereInstance, distroyAfterSeconds);
        }       
    }

    void PlaceSphereBack()
    {
        if (isTarget == true && LogCogTask.buttonTime < timeInstantiating)
        {
            Debug.Log("Missed target."); //Add line to file

            string newLine = CreateCSV.ID + "," + SceneCount.sceneCount + ","
                    + "999" + "," + timeInstantiating + ","
                    + isTarget + "," + "999"
                    + System.Environment.NewLine;

            StreamWriter writer = new StreamWriter(CreateCSV.pathCog, true);
            writer.Dispose();

            File.AppendAllText(CreateCSV.pathCog, newLine);

            isTarget = false;
            timeInstantiating = Time.time;
            Debug.Log("Distractor instantiated: " + timeInstantiating);

            var rotation = new Quaternion();
            rotation.eulerAngles = new Vector3(0, 0, 0);
            for (int i = 0; i < numberOfSpheres; i++)
            {
                sphereInstance = Instantiate(sphere, GeneratedPositionBack(), rotation);
            }
            Destroy(sphereInstance, distroyAfterSeconds);
        }
        else
        {
            isTarget = false;
            timeInstantiating = Time.time;
            Debug.Log("Distractor instantiated: " + timeInstantiating);

            var rotation = new Quaternion();
            rotation.eulerAngles = new Vector3(0, 0, 0);
            for (int i = 0; i < numberOfSpheres; i++)
            {
                sphereInstance = Instantiate(sphere, GeneratedPositionBack(), rotation);
            }
            Destroy(sphereInstance, distroyAfterSeconds);
        }
    }
}