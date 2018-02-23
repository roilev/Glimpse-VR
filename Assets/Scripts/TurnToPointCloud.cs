using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnToPointCloud : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.SetIndices(mesh.triangles, MeshTopology.Points, 0);

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
