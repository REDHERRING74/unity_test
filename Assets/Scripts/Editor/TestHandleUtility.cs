using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
public class TestHandleUtility : Editor {

    static TestHandleUtility()
    {
        Test();
    }

    static void Test()
    {
        SceneView.onSceneGUIDelegate -= OnSceneGUI;
        SceneView.onSceneGUIDelegate += OnSceneGUI;        
    }

    static void OnSceneGUI(SceneView sceneView)
    {
        Vector3 cameraPosition = GameObject.Find("Main Camera").transform.position;
        Debug.Log(cameraPosition);
        Debug.Log(HandleUtility.GUIPointToWorldRay(new Vector2(30, 30)));
        Debug.Log(HandleUtility.WorldToGUIPoint(new Vector3(30, 30, 30)));

        Vector3 spherePosition = new Vector3(0, 0, 0);
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = spherePosition;

        Vector2 guiPosition = HandleUtility.WorldToGUIPoint(spherePosition);
        Debug.Log(guiPosition);
    }
}
