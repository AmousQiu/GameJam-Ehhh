using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class ClickCounts : MonoBehaviour
{

    public Text scoreText;
    public int score=0;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            score++;
        }
        GetComponent<TextMesh>().text = "" + score;

    }
}
