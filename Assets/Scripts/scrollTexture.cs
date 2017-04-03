using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollTexture : MonoBehaviour {

    public MeshRenderer meshGuy;
    private Material mat; 

	// Use this for initialization
	void Start () {
        mat = meshGuy.material;

    }
	
	// Update is called once per frame
	void Update () {

        mat.mainTextureOffset += new Vector2(.006f, 0);

    }
}
