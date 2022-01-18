using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Bismark : Transport
{
    //DataBase dataBase;
    //[SerializeField] private Text nameTransport;
    //[SerializeField] private Text massTransport;
    //[SerializeField] private Text capacityTransport;
    //[SerializeField] private Text maxSpeedTransport;
    //[SerializeField] private int ID;

    //private void Start()
    //{
    //    dataBase = new DataBase();
    //}

    //public override void QWERTY()
    //{
    //    //dataBase.DisplayTransport();
    //    //dataBase.GetID(1);
    //    nameTransport.text = dataBase.GetName(ID);
    //    massTransport.text = dataBase.GetMass(ID).ToString();
    //    capacityTransport.text = dataBase.GetCapacity(ID).ToString();
    //    maxSpeedTransport.text = dataBase.GetMaxSpeed(ID).ToString();
    //}
    //public void STARTQ()
    //{
    //    DataTable transport = MyDataBase.GetTable("SELECT * FROM Transport ORDER BY Mass DESC;");

    //    int greatestMass = int.Parse(transport.Rows[0][1].ToString());

    //    string nickname = MyDataBase.ExecuteQueryWithAnswer($"SELECT Name FROM Transport WHERE id_transport = {greatestMass};");
    //    Debug.Log($"Транспорт {nickname} его масса {transport.Rows[0][2].ToString()} .");
    //}
}
