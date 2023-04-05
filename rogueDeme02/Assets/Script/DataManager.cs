using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager
{
    private ReadCSV readCSV = new ReadCSV();
    private (string[], int) enemyData;

    // 启动时所需加载的数据
    public void ReadAllCSV()
    {
        enemyData = readCSV.GetCsvData("Enemey");
    }

    // 返回指定数据
    public (string[], int) GetEnemyData()
    {
        return enemyData;
    }
}
