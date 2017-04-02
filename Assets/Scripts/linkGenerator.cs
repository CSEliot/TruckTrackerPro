using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linkGenerator : MonoBehaviour {

    //This script has a reference to all set able values and converts it to a link string (?&..) 

    public TruckData truckingData;


    //References:
    //PICK UP REFs
    public tk2dUIDropDownMenu P_stateMenu;
    public tk2dUIDropDownMenu P_cityMenu;




    //PICK UP REFs
    public tk2dUIDropDownMenu D_stateMenu;
    public tk2dUIDropDownMenu D_cityMenu;



    void MakeLink ()
    {
        Debug.Log("making link");

        truckingData.pickUpInfo.stateIndex = (System.Array.IndexOf(P_stateMenu.startingItemList, P_stateMenu.selectedTextMesh.text));
        truckingData.pickUpInfo.cityIndex = (System.Array.IndexOf(P_cityMenu.startingItemList, P_cityMenu.selectedTextMesh.text));




        truckingData.dropOffInfo.stateIndex = (System.Array.IndexOf(D_stateMenu.startingItemList, D_stateMenu.selectedTextMesh.text));
        truckingData.dropOffInfo.cityIndex = (System.Array.IndexOf(D_cityMenu.startingItemList, D_cityMenu.selectedTextMesh.text));
    }

}
