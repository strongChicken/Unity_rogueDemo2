using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadCSV
{
    // 负责解析指定的CSV表格和KEY位置，将结果和位置返回；
    private int keyCol;
    private string[] dataList;
    private int index;

    public (string[], int) GetCsvData(string fieldName)
    {
        Debug.Log("fieldName " + fieldName);
        TextAsset csvData = Resources.Load<TextAsset>(fieldName);   // TODO csvData是null
        Debug.Log("csvData " + csvData);
        string[] data = csvData.text.Split('\n');
        string[] keyRow = data[0].Split(',');

        // 获取key所在的列数
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
