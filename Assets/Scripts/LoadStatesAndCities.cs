using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadStatesAndCities : MonoBehaviour
{

    //Reference to file with all cities and states:



    //References to scene to populate visuals with correct states and cities

    public List<StateCities> allStateCities;

    void Start()
    {
        //List<string> stringy = new List<string>();
        //stringy.Add("ahhah");
        SetStates(ParseManager.GetStates(false));
        //SetStates(stringy);
    }

    public void SetStates(List<string> allStates)
    {
        for (int i = 0; i < allStateCities.Count; i++)
        {


            allStateCities[i].States.startingItemList = allStates;
            allStateCities[i].States.ItemList = allStates;
            allStateCities[i].States.UpdateList();
        }


    }

    void LoadCities()
    {
        allStateCities[0].Cities.startingItemList = ParseManager.GetCities(allStateCities[0].States.selectedTextMesh.text, false);
        allStateCities[0].Cities.ItemList = allStateCities[0].Cities.startingItemList;
        allStateCities[0].Cities.UpdateList();
    }

    public void GetCitiesPerState()
    {
        for (int i = 0; i < allStateCities.Count; i++)
        {
            //Ref to cities list per state index:
            //allStateCities[i].States.Index


        }


    }
}
