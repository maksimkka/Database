using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;

public class DataBase
{
    private string fileName;
    string name;
    int mass;
    int capacity;
    int maxSpeed;
    string uniqueProperties;

    //public SqliteConnection dbConnection;
    //private string path;


    //public void CreateDB()
    //{
    //    using (var connection = new SqliteConnection(fileName))
    //    {
    //        connection.Open();

    //        using (var command = connection.CreateCommand())
    //        {
    //            command.CommandText = "CREATE TABLE IF NOT EXISTS weapons (name VARCHAR(20), damage INT);";
    //            command.ExecuteNonQuery();
    //        }

    //        connection.Close();
    //    }
    //}

    //public void DataAcquisition(int id)
    //{
    //    fileName = Application.dataPath + "/StreamingAssets/db.db";
    //    using (var connection = new SqliteConnection("URI=file:" + fileName))
    //    {
    //        connection.Open();

    //        using (var command = connection.CreateCommand())
    //        {
    //            //command.CommandText = "SELECT * FROM Transport;";
    //            command.CommandText = $"SELECT * FROM Transport WHERE id_transport = {id};";

    //            //using (IDataReader reader = command.ExecuteReader())
    //            using (IDataReader reader = command.ExecuteReader())
    //            {
    //                while (reader.Read())
    //                {
    //                    name = reader["Name"].ToString();
    //                    mass = Convert.ToInt32(reader["Mass"]);
    //                    capacity = Convert.ToInt32(reader["Capacity"]);
    //                    maxSpeed = Convert.ToInt32(reader["MaxSpeed"]);
    //                }

    //                reader.Close();
    //            }

    //            connection.Close();
    //        }
    //    }
    //}

    public void NameAcquisition(int id)
    {
        fileName = Application.dataPath + "/StreamingAssets/db.db";
        using (var connection = new SqliteConnection("URI=file:" + fileName))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = $"SELECT name from Transports inner join KindOfTransport on Transports.id_kindOfTransports = KindOfTransport.id WHERE Transports.id = {id};";

                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        name = reader["name"].ToString();
                    }

                    reader.Close();
                }

                connection.Close();
            }
        }
    }

    public void CharacteristicAcquisition(int id)
    {
        fileName = Application.dataPath + "/StreamingAssets/db.db";
        using (var connection = new SqliteConnection("URI=file:" + fileName))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = $"SELECT * from Transports inner join Characteristics on Transports.id_characteristics = Characteristics.id WHERE Transports.id = {id};";

                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        mass = Convert.ToInt32(reader["mass"]);
                        capacity = Convert.ToInt32(reader["capacity"]);
                        maxSpeed = Convert.ToInt32(reader["maxSpeed"]);
                    }

                    reader.Close();
                }

                connection.Close();
            }
        }
    }

    public void UniquePropertiesAcquisition(int id)
    {
        fileName = Application.dataPath + "/StreamingAssets/db.db";
        using (var connection = new SqliteConnection("URI=file:" + fileName))
        {
            connection.Open();

            using (var command = connection.CreateCommand())
            {
                command.CommandText = $"SELECT * from Transports " +
                                      $"inner join UniqueProperties on Transports.id_uniqueProperties = UniqueProperties.id " +
                                      $"WHERE Transports.id = {id} ;";
                                      //$"AND UniqueProperties.displacements " +
                                      //$"OR UniqueProperties.liftingForce " +
                                      //$"OR UniqueProperties.color IS NOT NULL;";
                                      //$"OR UniqueProperties.size IS NOT NULL;";

                using (IDataReader reader = command.ExecuteReader())
                {
                    // while (reader.Read())
                    //{

                    int i = id;
                    if (i == 1)
                    {
                        uniqueProperties = reader["displacements"].ToString();
                        //uniqueProperties = reader[""].ToString();
                        // Debug.Log($"{uniqueProperties}  1");
                    }

                    else if (i == 2)
                    {
                        uniqueProperties = reader["liftingForce"].ToString();
                        // Debug.Log($"{uniqueProperties}  2");
                    }

                    else if (i == 3)
                    {
                        uniqueProperties = reader["color"].ToString();
                        // Debug.Log($"{uniqueProperties}  3");
                    }

                    else
                    {
                        uniqueProperties = reader["size"].ToString();
                        // Debug.Log($"{uniqueProperties}  4");
                    }
                    //}

                    reader.Close();
                }

                connection.Close();
            }
        }
    }

    public string OutputName(int id)
    {
        NameAcquisition(id);
        return name;
    }

    public int OutputMass(int id)
    {
        CharacteristicAcquisition(id);
        return mass;
    }

    public int OutputCapacity()
    {
        return capacity;
    }

    public int OutputMaxSpeed()
    {
        return maxSpeed;
    }

    public string OutputUniqueProperties(int id)
    {
        UniquePropertiesAcquisition(id);
        return uniqueProperties;
    }
}