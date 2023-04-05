using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadCSV
{
    // �������ָ����CSV����KEYλ�ã��������λ�÷��أ�
    private int keyCol;
    private string[] dataList;
    private int index;

    public (string[], int) GetCsvData(string fieldName)
    {
        Debug.Log("fieldName " + fieldName);
        TextAsset csvData = Resources.Load<TextAsset>(fieldName);   // TODO csvData��null
        Debug.Log("csvData " + csvData);
        string[] data = csvData.text.Split('\n');
        string[] keyRow = data[0].Split(',');

        // ��ȡkey���ڵ�����
        for (int i = 0; i < data[0].Length - 1; i++)
        {
            if (keyRow[i] == "key")
            {
                keyCol = i;
                break;
            }
        }

        return (data, keyCol);
    }
}
