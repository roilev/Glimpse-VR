using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class FirstCollision : MonoBehaviour {

    public bool visit = true;
    public int visitorNumber = 0;

	void Start () {

        string filePath = Application.streamingAssetsPath + Path.DirectorySeparatorChar + "NumberOfVisitors.txt";
        if (File.Exists(filePath))
        {
            Debug.Log("found visit number");
            string visitorsString = File.ReadAllText(filePath);
            visitorNumber = int.Parse(visitorsString);
        }

	}
	
	void Update () {

	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.gameObject.tag == "PlayerCollider")
        {
            if (visit) {
                Debug.Log("Activated");
                visitorNumber++;
                Debug.Log(visitorNumber);
                visit = false;

            }

            string filePath = Application.streamingAssetsPath + Path.DirectorySeparatorChar + "NumberOfVisitors.txt";
            File.WriteAllText(filePath, visitorNumber.ToString());

            TextMesh text = GetComponentInChildren<TextMesh>();
            text.text = "You are visitor number " + visitorNumber + " in this world";
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.gameObject.tag == "PlayerCollider")
        {
            Debug.Log("Deactivated");
        }
    }

}