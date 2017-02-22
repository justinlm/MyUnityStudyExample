using UnityEngine;
using System.Collections;

public class DebugTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () 
    {
        Debug.DrawRay(this.transform.position, this.transform.right * 30, Color.red, 0.1f);
        Debug.DrawLine(this.transform.position, this.transform.right * 30, Color.red, 0.1f);
	}
}
