using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SHOWURL : MonoBehaviour {

    #region Public Objs
    public Text MyUITEXT1;
    public Text MyUITEXT2;
    #endregion

    // Use this for initialization
    void Start () {
        MyUITEXT1.text = Application.absoluteURL;
        MyUITEXT2.text = Application.srcValue;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
