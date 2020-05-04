//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI.Extensions;

//public class DrawLineUI : MonoBehaviour {


//    public GameObject linePrefab;
//    public GameObject currentLine;

//    //public LineRenderer lineRenderer;
//    public UnityEngine.UI.Extensions.UILineRenderer lineRenderer;
//    public EdgeCollider2D edgeCollider;
//    public List<Vector2> fingerPositions;

//    // Use this for initialization
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (Input.GetMouseButtonDown(0)) //initial click
//        {
//            CreateLine();
//        }
//        if (Input.GetMouseButton(0)) //is the mouse hold down?
//        {
//            Vector2 tempFingerPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
//            if (Vector2.Distance(tempFingerPos, fingerPositions[fingerPositions.Count - 1]) > .1f)
//            {
//                UpdateLine(tempFingerPos);
//            }
//        }
//    }

//    void CreateLine()
//    {
//        currentLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity);
//        //lineRenderer = currentLine.GetComponent<LineRenderer>();
//        lineRenderer = currentLine.GetComponent<UnityEngine.UI.Extensions.UILineRenderer>();
//        edgeCollider = currentLine.GetComponent<EdgeCollider2D>();
//        fingerPositions.Clear(); // clear list for new line
//        fingerPositions.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
//        fingerPositions.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
//        lineRenderer.SetPosition(0, fingerPositions[0]);
//        lineRenderer.SetPosition(1, fingerPositions[1]);
//        edgeCollider.points = fingerPositions.ToArray();
//    }

//    void UpdateLine(Vector2 newFingerPos)
//    {
//        fingerPositions.Add(newFingerPos);
//        lineRenderer.positionCount++;
//        lineRenderer.SetPosition(lineRenderer.positionCount - 1, newFingerPos);
//        edgeCollider.points = fingerPositions.ToArray();

//    }
//}

