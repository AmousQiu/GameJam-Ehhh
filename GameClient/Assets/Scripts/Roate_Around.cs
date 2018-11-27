using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roate_Around : MonoBehaviour {
    private GameObject m_LeftObject;
    private GameObject m_RightObject;
    // Use this for initialization
    void Start()
    {

    }
	// Update is called once per frame
	void Update () {
            // Rotate the object around its local X axis at 1 degree per second
            Debug.Log("default");
        transform.Rotate(Vector3.right * Time.deltaTime);

        // ...also rotate around the World's Y axis
        transform.Rotate(Vector3.up * Time.deltaTime, Space.World);
	}
    
}
