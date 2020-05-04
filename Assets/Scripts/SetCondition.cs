using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetCondition : MonoBehaviour {

	public void ChangeCondition()
    {
        //0: "0_0.0_ECGInstruction"
        //1: "1_0.0_ECGInstruction"
        //2: "2_0.0_ECGInstruction"
        //3: "3_0.0_ECGInstruction"

        //4: "4_0.0_ECGInstruction"
        //5: "5_0.0_ECGInstruction"
        //6: "6_0.0_ECGInstruction"
        //7: "7_0.0_ECGInstruction"

        //END: "END"

        Debug.Log("Condition " + CreateCSV.cond);
        Debug.Log("Order " + CreateCSV.ord);
        Debug.Log("SceneCount " + SceneCount.sceneCount);

        if (CreateCSV.cond == 0)
        {
            if (CreateCSV.ord == 0)
            {
                if (SceneCount.sceneCount == 0) SceneManager.LoadSceneAsync("0_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 1) SceneManager.LoadSceneAsync("1_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 2) SceneManager.LoadSceneAsync("2_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 3) SceneManager.LoadSceneAsync("3_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 4) SceneManager.LoadSceneAsync("END");
            }
            else if (CreateCSV.ord == 1)
            {
                if (SceneCount.sceneCount == 0) SceneManager.LoadSceneAsync("1_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 1) SceneManager.LoadSceneAsync("0_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 2) SceneManager.LoadSceneAsync("3_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 3) SceneManager.LoadSceneAsync("2_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 4) SceneManager.LoadSceneAsync("END");
            }
            else if (CreateCSV.ord == 2)
            {
                if (SceneCount.sceneCount == 0) SceneManager.LoadSceneAsync("2_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 1) SceneManager.LoadSceneAsync("3_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 2) SceneManager.LoadSceneAsync("1_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 3) SceneManager.LoadSceneAsync("0_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 4) SceneManager.LoadSceneAsync("END");
            }
            else if (CreateCSV.ord == 3)
            {
                if (SceneCount.sceneCount == 0) SceneManager.LoadSceneAsync("3_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 1) SceneManager.LoadSceneAsync("2_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 2) SceneManager.LoadSceneAsync("0_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 3) SceneManager.LoadSceneAsync("1_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 4) SceneManager.LoadSceneAsync("END");
            }
        }
        else if (CreateCSV.cond == 1)
        {
            if (CreateCSV.ord == 0)
            {
                if (SceneCount.sceneCount == 0) SceneManager.LoadSceneAsync("4_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 1) SceneManager.LoadSceneAsync("5_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 2) SceneManager.LoadSceneAsync("6_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 3) SceneManager.LoadSceneAsync("7_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 4) SceneManager.LoadSceneAsync("END");
            }
            else if (CreateCSV.ord == 1)
            {
                if (SceneCount.sceneCount == 0) SceneManager.LoadSceneAsync("5_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 1) SceneManager.LoadSceneAsync("4_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 2) SceneManager.LoadSceneAsync("7_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 3) SceneManager.LoadSceneAsync("6_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 4) SceneManager.LoadSceneAsync("END");
            }
            else if (CreateCSV.ord == 2)
            {
                if (SceneCount.sceneCount == 0) SceneManager.LoadSceneAsync("6_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 1) SceneManager.LoadSceneAsync("7_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 2) SceneManager.LoadSceneAsync("5_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 3) SceneManager.LoadSceneAsync("4_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 4) SceneManager.LoadSceneAsync("END");
            }
            else if (CreateCSV.ord == 3)
            {
                if (SceneCount.sceneCount == 0) SceneManager.LoadSceneAsync("7_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 1) SceneManager.LoadSceneAsync("6_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 2) SceneManager.LoadSceneAsync("4_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 3) SceneManager.LoadSceneAsync("5_0.0_ECGInstruction");
                else if (SceneCount.sceneCount == 4) SceneManager.LoadSceneAsync("END");
            }
        }
    }
}
