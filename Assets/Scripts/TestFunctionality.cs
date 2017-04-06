using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestFunctionality : MonoBehaviour
{

    private bool testRan;

    #region Public Test Vars
    public bool TestInRelease;
    public bool TestWeb; //Get the data URL locally, or use the browser URL.
    public string TestURL;
    public string TestCode;
    #endregion

    // Use this for initialization
    void Start()
    {
        testRan = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!testRan && TestInRelease && ParseManager.DoneInstantiating && URLLoader.DoneInstatiating)
        {
            if (!Application.isEditor && !TestInRelease)
                return;
            testRan = true;
            URLLoader.BuildURL(URLLoader.GetDataFrom(TestURL + "?" + TestCode).ToArray());
            CBUG.Do("Retrieved URL: " + URLLoader.URL);
        }
    }
}
