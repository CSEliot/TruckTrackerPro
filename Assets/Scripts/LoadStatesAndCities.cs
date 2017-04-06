using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadStatesAndCities : MonoBehaviour
{

    //Reference to file with all cities and states:


    public linkGenerator linkMan;
    //References to scene to populate visuals with correct states and cities

    public List<StateCities> allStateCities;

    public static bool DoneInstantiating;

    void Start()
    {
    }

    private void Update()
    {
        if(!DoneInstantiating && ParseManager.DoneInstantiating && URLLoader.DoneInstatiating)
        {
            DoneInstantiating = true;
            SetStates(ParseManager.GetStates(false));
        }
    }

    public void SetStates(List<string> allStates)
    {
        for (int i = 0; i < allStateCities.Count; i++)
        {
            allStateCities[i].States.startingItemList = allStates;
            allStateCities[i].States.ItemList = allStates;
            allStateCities[i].States.UpdateList();

            allStateCities[i].Cities.startingItemList = ParseManager.GetCities(allStateCities[i].States.selectedTextMesh.text, false);
            allStateCities[i].Cities.ItemList = allStateCities[i].Cities.startingItemList;
            allStateCities[i].Cities.UpdateList();
        }

    }

    public void LoadCities()
    {
        allStateCities[0].Cities.startingItemList = ParseManager.GetCities(allStateCities[0].States.selectedTextMesh.text, false);
        allStateCities[0].Cities.ItemList = allStateCities[0].Cities.startingItemList;
        allStateCities[0].Cities.UpdateList();

        linkMan.SetDispatchStateCity();
        linkMan.SetPickUpStateCity();
        linkMan.SetDropOffStateCity();
    }

    public void LoadCities2()
    {
        allStateCities[1].Cities.startingItemList = ParseManager.GetCities(allStateCities[1].States.selectedTextMesh.text, false);
        allStateCities[1].Cities.ItemList = allStateCities[1].Cities.startingItemList;
        allStateCities[1].Cities.UpdateList();

        linkMan.SetDispatchStateCity();
        linkMan.SetPickUpStateCity();
        linkMan.SetDropOffStateCity();
    }

    public void LoadCities3()
    {
        allStateCities[2].Cities.startingItemList = ParseManager.GetCities(allStateCities[2].States.selectedTextMesh.text, false);
        allStateCities[2].Cities.ItemList = allStateCities[2].Cities.startingItemList;
        allStateCities[2].Cities.UpdateList();

        linkMan.SetDispatchStateCity();
        linkMan.SetPickUpStateCity();
        linkMan.SetDropOffStateCity();
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
