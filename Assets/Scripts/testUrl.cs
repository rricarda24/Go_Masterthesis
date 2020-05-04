using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace ZenFulcrum.EmbeddedBrowser
{
    public class testUrl : MonoBehaviour
    {
        public static string myUrl;
        public Browser myBrowser;
        public string participantID;
        public int sceneCount;

        public Button reload;

        // Use this for initialization
        void Start()
        {
            //myUrl = "http://localhost/EmBodyToolAddapted/paintannotate.php?perc=0&userID=3&presentation=0";
            GenerateUrl();
            Debug.Log("URL: " + myUrl);
            myBrowser.LoadURL(myUrl, true);

        }

        public void GenerateUrl()
        {
            //string participantID = CreateCSV.ID;

            if (sceneCount == 0)
            {
                myUrl = "http://localhost/EmBodyToolAddapted/paintannotate.php?perc=0&userID=" + participantID + "&presentation=0";
            }
            else if (sceneCount == 1)
            {
                myUrl = "http://localhost/EmBodyToolAddapted/paintannotate.php?perc=20&userID=" + participantID + "&presentation=1";
            }
            else if (sceneCount == 2)
            {
                myUrl = "http://localhost/EmBodyToolAddapted/paintannotate.php?perc=40&userID=" + participantID + "&presentation=2";
            }
            else if (sceneCount == 3)
            {
                myUrl = "http://localhost/EmBodyToolAddapted/paintannotate.php?perc=60&userID=" + participantID + "&presentation=3";
            }
            else //SceneCount.sceneCount == 4
            {
                myUrl = "http://localhost/EmBodyToolAddapted/paintannotate.php?perc=80&userID=" + participantID + "&presentation=4";
            }

            Debug.Log("URL= " + myUrl);

        }

        public void Reload()
        {
            myBrowser.LoadURL(myUrl, true);
            reload.interactable = true;

        }
    }
}
