using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Location {

    public int stateIndex;
    public int cityIndex;

    public int dateMonth;
    public int dateDay;
    public int dateYear;

    //1 - 12
    public int timeHour;
    //0-59
    public int timeMin;
    //true = am, false = pm
    public bool isAM;



}
