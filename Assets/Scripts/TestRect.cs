using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestRect : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Test();
	}
	
    void Test()
    {
        Rect rect = new Rect(0, 0, 30, 30);

        Debug.Log(Rect.PointToNormalized(rect, new Vector2(15, 15)));
        Debug.Log(Rect.NormalizedToPoint(rect, new Vector2(0.5f, 0.1f)));

        Debug.Log(rect.Contains(Vector2.zero));
        Debug.Log(rect.Contains(new Vector2(1, 1)));

        Debug.Log(rect.Overlaps(new Rect(0, 0, 30, 30)));
        Debug.Log(rect.Overlaps(new Rect(1, 1, 31, 31)));
        Debug.Log(rect.Overlaps(new Rect(31, 31, 1, 1)));
        Debug.Log(rect.Overlaps(Rect.zero));

        Debug.Log(rect.Overlaps(new Rect(1, 1, -1, -1)));
        Debug.Log(rect.Overlaps(new Rect(1, 1, -1, -1), false));
        Debug.Log(rect.Overlaps(new Rect(1, 1, -1, -1), true));

        rect.Set(1, 1, 1, 1);
        Debug.Log(rect);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
