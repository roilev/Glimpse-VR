using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigToPoints : MonoBehaviour {
    Mesh mesh;
    // Use this for initialization
    private void Awake()
    {
        mesh = GetComponent<SkinnedMeshRenderer>().sharedMesh;
        mesh.SetIndices(mesh.triangles, MeshTopology.Points, 0);
    }
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
