using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.UI;
using UnityEngine.Networking;

public class Connection : MonoBehaviour
{
    public SqliteConnection dbConnection;
    private string path;

    public void SetConnection()
    {
        path = Application.dataPath + "/Db/db.db";
        dbConnection = new SqliteConnection("URI=file:" + path);
        dbConnection.Open();
        if (dbConnection.State == ConnectionState.Open)
        {
            SqliteCommand command = new SqliteCommand();
            command.Connection = dbConnection;
            command.CommandText = "SELECT * FROM Transport";
            SqliteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Debug.Log(reader[0]);
                Debug.Log(reader[1]);
                Debug.Log(reader[2]);
                Debug.Log(reader[3]);
            }
        }
    }

    //public void Send()
    //{
    //    path = Application.dataPath + "/Db/db.db";
    //    dbConnection = new SqliteConnection("URI=file:" + path);
    //    WWWForm form = new WWWForm();
    //    form.AddField("HELLO", "HI");
    //    UnityWebRequest www = new UnityWebRequest(nameof(dbConnection));

    //}
    //public void Send()
    //{
    //    path = Application.dataPath + "/Db/db.db";
    //    dbConnection = new SqliteConnection("URI=file:" + path);
    //    Debug.Log("JOPA");
    //    StartCoroutine(LoadTextFromServer(path));
    //}

    //IEnumerator LoadTextFromServer(string url, Action<string> response)
    //{
    //    var request = UnityWebRequest.Get(url);

    //    yield return request.SendWebRequest();

    //    if (!request.isHttpError && !request.isNetworkError)
    //    {
    //        response(uwr.downloadHandler.text);
    //    }
    //    else
    //    {
    //        Debug.LogErrorFormat("error request [{0}, {1}]", url, request.error);

    //        response(null);
    //    }

    //    request.Dispose();
    //}
}
