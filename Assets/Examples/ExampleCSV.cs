using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DaleranGames.SimpleCSVReader;

[ExecuteInEditMode]
public class ExampleCSV : MonoBehaviour
{
    [ContextMenu("Print Example.csv")]
    void PrintCSV()
    {
        CSVData csv = new CSVData("Example", Application.dataPath + "/Examples/example.csv");
        csv.Print();
    }

}
