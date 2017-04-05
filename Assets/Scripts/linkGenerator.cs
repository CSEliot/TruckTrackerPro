using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class linkGenerator : URLLoader
{



    public DataPoint dispPt;
    public DataPoint startPt;
    public DataPoint endPt;


    //This script has a reference to all set able values and converts it to a link string (?&..) 
    [System.Serializable]
    public class PointRef
    {
        public tk2dUIDropDownMenu stateMenu;
        public tk2dUIDropDownMenu cityMenu;

        public tk2dUITextInput date_month;
        public tk2dUITextInput date_day;
        public tk2dUITextInput date_year;

        public tk2dUITextInput time_hour;
        public tk2dUITextInput time_min;
        public tk2dUIDropDownMenu amPm;
    }
    //References:



    public tk2dUIDropDownMenu truckType;
    public tk2dUIDropDownMenu statusStage;

    //TRuck Start REFs
    public OneSetData otherData;
       

    public PointRef DispatchRef;


    //PICK UP REFs
    public PointRef PickupRef;




    //Drop off REFs
    public PointRef DropoffRef;



    void MakeLink ()
    {
        Debug.Log("making link");

       //dispPt.Time = 

        
        //URLLoader.DataPoint StartPoint = new DataPoint(mylabel, mytime, mycitycode, mystatecode);

        //URLLoader.DataPoint EndPoint = new DataPoint(mylabel, mytime, mycitycode, mystatecode);
        URLLoader.BuildURL(dispPt, startPt, endPt);
        //URLLoader.BuildURL

            //DataPoint(string Time, string CityCode, string StateCode, string TruckID)
        
    }

    public void SetVanType()
    {
        otherData.trailerType = truckType.Index.ToString();
    }

    public void SetStatus()
    {
        otherData.status = statusStage.Index.ToString();
    }




    public void SetDispatchStateCity()
    {
        dispPt.StateCode = DispatchRef.stateMenu.Index.ToString();
        dispPt.CityCode = DispatchRef.cityMenu.Index.ToString();
    }

    public void SetPickUpStateCity()
    {
        startPt.StateCode = PickupRef.stateMenu.Index.ToString();
        startPt.CityCode = PickupRef.cityMenu.Index.ToString();
    }

    public void SetDropOffStateCity()
    {
        endPt.StateCode = DropoffRef.stateMenu.Index.ToString();
        endPt.CityCode = DropoffRef.cityMenu.Index.ToString();
    }


    public void SetDispatchTime()
    {
        //date first, then time
        if (DispatchRef.amPm.Index == 0)
        {
            dispPt.Time = DispatchRef.date_month.Text + DispatchRef.date_day.Text + DispatchRef.date_year.Text + DispatchRef.time_hour.Text + DispatchRef.time_min.Text;
        }
        else
        {
            dispPt.Time = DispatchRef.date_month.Text + DispatchRef.date_day.Text + DispatchRef.date_year.Text + (int.Parse(DispatchRef.time_hour.Text) + 12).ToString() + DispatchRef.time_min.Text;
        }

    }

    public void SetPickUpTime()
    {
        //date first, then time
        if (PickupRef.amPm.Index == 0)
        {
            startPt.Time = PickupRef.date_month.Text + PickupRef.date_day.Text + PickupRef.date_year.Text + PickupRef.time_hour.Text + PickupRef.time_min.Text;
        }
        else
        {
            startPt.Time = PickupRef.date_month.Text + PickupRef.date_day.Text + PickupRef.date_year.Text + (int.Parse(PickupRef.time_hour.Text) + 12).ToString() + PickupRef.time_min.Text;
        }



    }


    public void SetDropOffTime()
    {
        //date first, then time
        if (DropoffRef.amPm.Index == 0)
        {
            endPt.Time = DropoffRef.date_month.Text + DropoffRef.date_day.Text + DropoffRef.date_year.Text + DropoffRef.time_hour.Text + DropoffRef.time_min.Text;
        }
        else
        {
            endPt.Time = DropoffRef.date_month.Text + DropoffRef.date_day.Text + DropoffRef.date_year.Text + (int.Parse(DropoffRef.time_hour.Text) + 12).ToString() + DropoffRef.time_min.Text;
        }



    }
}
