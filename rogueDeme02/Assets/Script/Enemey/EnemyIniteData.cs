using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIniteData
{
    // 负责通过ID返回指定数据stirng[]

    private DataManager data = new DataManager();
    private string[] dataList;
    private int keyCol;
    private string[] dataRow;

    private NormalEnemy normalEnemy;
    private BossEnemy bossEnemy;


    // 通过怪物ID获取数据
    public void EnemyIniteAttributes(int enmeyID)
    {
        (dataList, keyCol) = data.GetEnemyData();
        for (int i = 2; i < dataList.Length-1; i++)
        {
            dataRow = dataList[i].Split(',');
            if (dataRow[keyCol] == enmeyID.ToString())
            {
                switch (dataRow[3])
                {
                    case ("1"):
                        // TODO 把获取的数据给到enemy对象
                        break;
                }
            }
        }
    }
}
