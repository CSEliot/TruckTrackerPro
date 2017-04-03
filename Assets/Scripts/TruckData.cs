using System;

[Serializable]
public class TruckData
{

    public int uniqueTruckID;
    //1,2,3 1= dryvan, 2 = flatbed, 3 = reefer
    public int truckType;
    public int currentStage;
    public Location truckStartInfo;
    public Location pickUpInfo;
    public Location dropOffInfo;
}
