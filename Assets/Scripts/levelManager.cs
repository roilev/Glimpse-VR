using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class levelManager : MonoBehaviour {
	
    // Model 0: companyman
    // Model 1: marchent
    // Model 2: soldier
    // Model 3: host
    // Model 4: artist

    public GameObject[] characters;


    public string randomizer = "glimpse_randomize.txt";

	// Use this for initialization
	void Start () {

		// Reading the file into string.
        string levelString = File.ReadAllText(Application.dataPath + Path.DirectorySeparatorChar + randomizer);

		// Splitting the string into lines.
		string[] charLines = levelString.Split('\n');

        // Iterating over the lines.
        for (int character = 0; character < charLines.Length; character++) {

            float axisX = 0;
            float axisY = 0;
            float axisZ = 0;

            //Line by line
            string currentLine = charLines[character];

            string[] axis = currentLine.Split(',');
            for (int singleAxe = 0; singleAxe < axis.Length; singleAxe++){

                float rangeStart = 0;
                float rangeEnd = 0;

                if (axis[singleAxe].Contains(":")){
                    string[] ranges = axis[singleAxe].Split(':');

                    for (int singleRange = 0; singleRange < axis.Length; singleRange++){
                        rangeStart = float.Parse(ranges[0]);
                        rangeEnd = float.Parse(ranges[1]);

                        if (singleAxe == 0){
                            axisX = Random.Range(rangeStart, rangeEnd);
                        } else if (singleAxe == 1) {
                            axisY = Random.Range(rangeStart, rangeEnd);
                        } else if (singleAxe == 2) {
                            axisZ = Random.Range(rangeStart, rangeEnd);
                        }
                    }

                } else {
                    if (singleAxe == 0){
                        //print("X is stationary on: " + axis[singleAxe]);
                        axisX = float.Parse(axis[singleAxe]);
                                     
                    } else if (singleAxe == 1){
                        //print("Y is stationary on: " + axis[singleAxe]);
                        axisY = float.Parse(axis[singleAxe]);

                    } else if (singleAxe == 2){
                        //print("Z is stationary on: " + axis[singleAxe]);
                        axisZ = float.Parse(axis[singleAxe]);
                    }

                }

            }

            characters[character].transform.localPosition = new Vector3(axisX, axisY, axisZ);
            print(characters[character] + ", " + characters[character].transform.localPosition);


        }		

	}
	
	void Update () {
		
	}
}
