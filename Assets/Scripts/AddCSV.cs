using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class AddCSV : MonoBehaviour {
    //Variables in CreateCSV.cs
    //string ID = CreateCSV.ID;
    //string date = System.DateTime.Now.ToString("dd.MM.yyyy");
    //string time = System.DateTime.Now.ToString("HH:mm");
    //int hand = CreateCSV.hand;
    //int cond = CreateCSV.cond;
    //int ord = CreateCSV.ord;
    //string comPortNr = CreateCSV.comPortNr;
    //int samArousalValue = CreateCSV.samArousalValue;
    //int samValenceValue = CreateCSV.samValenceValue;

    string newLine;

    public void AmendFile()
    {
        string path = CreateCSV.path;
        Debug.Log("Pfad: " + path);

        string ID = CreateCSV.ID;

        string date = System.DateTime.Now.ToString("dd.MM.yyyy");
        string time = System.DateTime.Now.ToString("HH:mm");

        string temp = CreateCSV.temp;

        int hand = CreateCSV.hand;
        int cond = CreateCSV.cond;
        int ord = CreateCSV.ord;

        string comPortNr = CreateCSV.comPortNr;

        int conditionNr = SceneCount.sceneCount;

        int samArousalValue = SAMScale.scoreSAMArousal;
        int samValenceValue = SAMScale.scoreSAMValence;

        float presenceScore;

        GameObject wall;
        Renderer rend;
        string colour;

        if (conditionNr == 0)
        {
            presenceScore = 999;

            colour = "999";
        }
        else
        {
            presenceScore = VASSlider.presenceScore;

            wall = GameObject.Find("Wall_back");
            rend = wall.GetComponent<Renderer>();
            colour = rend.material.ToString();
            colour = colour.Substring(0, 17);
        }
        

        StreamWriter writer = new StreamWriter(path, true);
        writer.Dispose();

        //string newLine = "1,2,3,4,5,6";

        newLine = ID + "," + date + "," + time + "," + temp + ","
            + hand + "," + cond + "," + ord + "," + comPortNr + ","
            + conditionNr + "," + samArousalValue + "," + samValenceValue + "," 
            + presenceScore + "," + colour + System.Environment.NewLine;

        //Debug.Log("Arousal " + samArousalValue);
        //Debug.Log("Valence " + samValenceValue);
        //Debug.Log("Presence " + presenceScore);
        //Debug.Log("Colour " + colour);

        File.AppendAllText(path, newLine);

    }

    //public void SetUpCogFile()
    //{
    //    string pathCog = CreateCSV.pathCog;
    //    //string pathCog = "Assets/CSV/15_cog.csv";
    //    newLine = System.Environment.NewLine + CreateCSV.ID + "," + SceneCount.sceneCount;

    //    File.AppendAllText(pathCog, newLine);
    //}

    

}
