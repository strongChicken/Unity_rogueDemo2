using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager
{
    private ReadCSV readCSV = new ReadCSV();
    private (string[], int) enemyData;

    // ����ʱ������ص�����
    public void ReadAllCSV()
    {
        enemyData = readCSV.GetCsvData("Enemey");
    }

    // ����ָ������
    public (string[], int) GetEnemyData()
    {
        return enemyData;
    }
}
