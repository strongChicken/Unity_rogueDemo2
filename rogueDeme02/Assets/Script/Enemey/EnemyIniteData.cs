using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIniteData
{
    // ����ͨ��ID����ָ������stirng[]

    private DataManager data = new DataManager();
    private string[] dataList;
    private int keyCol;
    private string[] dataRow;

    private NormalEnemy normalEnemy;
    private BossEnemy bossEnemy;


    // ͨ������ID��ȡ����
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
                        // TODO �ѻ�ȡ�����ݸ���enemy����
                        break;
                }
            }
        }
    }
}
