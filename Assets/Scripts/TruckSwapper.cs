using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckSwapper : MonoBehaviour {

    public GameObject fTruck;
    public GameObject rTruck;
    public GameObject dTruck;


    void TruckSwap(int i)
    {
        if( i == 1)
        {
            Dtruck();
        }else if (i == 2)
        {
            Ftruck();
        }
        else if (i == 3)
        {
            Rtruck();
        }
    }


    void Dtruck()
    {
        fTruck.SetActive(false);
        rTruck.SetActive(false);
        dTruck.SetActive(true);
    }

    void Ftruck ()
    {
        fTruck.SetActive(true);
        rTruck.SetActive(false);
        dTruck.SetActive(false);
    }


    void Rtruck()
    {
        fTruck.SetActive(false);
        rTruck.SetActive(true);
        dTruck.SetActive(false);
    }


}
