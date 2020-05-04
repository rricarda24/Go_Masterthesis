using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZenFulcrum.EmbeddedBrowser
{

    public class BodyMapURL : MonoBehaviour {

        // Example: particpantID = 1
        // http://localhost/EmBodyToolAddapted/paintannotate.php?perc=0&userID=1&presentation=0
        // http://localhost/EmBodyToolAddapted/paintannotate.php?perc=20&userID=1&presentation=1
        // http://localhost/EmBodyToolAddapted/paintannotate.php?perc=40&userID=1&presentation=2
        // http://localhost/EmBodyToolAddapted/paintannotate.php?perc=60&userID=1&presentation=3
        // http://localhost/EmBodyToolAddapted/paintannotate.php?perc=80&userID=1&presentation=4


        public static string myUrl;
        public Browser myBrowser;

        private void Start()
        {
            //myUrl = "http://localhost/EmBodyToolAddapted/paintannotate.php?perc=0&userID=3&presentation=0";
            GenerateUrl();
            Debug.Log("URL: " + myUrl);
            myBrowser.LoadURL(myUrl, true);
        }

        public void GenerateUrl()
        {
            string participantID = CreateCSV.ID;

            if (SceneCount.sceneCount == 0)
            {
                myUrl = "http://localhost/EmBodyToolAddapted/paintannotate.php?perc=0&userID=" + participantID + "&presentation=0";
            }
            else if (SceneCount.sceneCount == 1)
            {
                myUrl = "http://localhost/EmBodyToolAddapted/paintannotate.php?perc=20&userID=" + participantID + "&presentation=1";
            }
            else if (SceneCount.sceneCount == 2)
            {
                myUrl = "http://localhost/EmBodyToolAddapted/paintannotate.php?perc=40&userID=" + participantID + "&presentation=2";
            }
            else if (SceneCount.sceneCount == 3)
            {
                myUrl = "http://localhost/EmBodyToolAddapted/paintannotate.php?perc=60&userID=" + participantID + "&presentation=3";
            }
            else //SceneCount.sceneCount == 4
            {
                myUrl = "http://localhost/EmBodyToolAddapted/paintannotate.php?perc=80&userID=" + participantID + "&presentation=4";
            }

            Debug.Log("URL= " + myUrl);

        }
    }
}
