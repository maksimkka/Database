using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;
using System;

public abstract class Transport : MonoBehaviour
{
    protected DataBase dataBase;
    [SerializeField] protected Text nameTransport;
    [SerializeField] protected Text massTransport;
    [SerializeField] protected Text capacityTransport;
    [SerializeField] protected Text maxSpeedTransport;
    [SerializeField] protected Text uniqueProperties;
    [SerializeField] protected TransportType transportType;
    protected int ID;

    private void Start()
    {
        dataBase = new DataBase();
    }

    public virtual void KlickButton()
    {
        //dataBase.DisplayTransport();
        //dataBase.GetID(1);
        GettingID();
        uniqueProperties.text = dataBase.OutputUniqueProperties(ID);
        nameTransport.text = dataBase.OutputName(ID);
        massTransport.text = dataBase.OutputMass(ID).ToString();
        capacityTransport.text = dataBase.OutputCapacity().ToString();
        maxSpeedTransport.text = dataBase.OutputMaxSpeed().ToString();
    }

    protected void GettingID()
    {
        switch (transportType)
        {
            case TransportType.Bismark:
                ID = 1;
                break;
            case TransportType.Boeing:
                ID = 2;
                break;
            case TransportType.BMWE34:
                ID = 3;
                break;
            case TransportType.Ducaty:
                ID = 4;
                break;
        }
    }
}
