using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Location {

    public string state;
    public string city;

    public string dateMonth;
    public string dateDay;
    public string dateYear;

    //1 - 12
    public string timeHour;
    //0-59
    public string timeMin;
    //true = am, false = pm
    public bool isAM;



}
