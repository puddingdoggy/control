using System.Collections;
using System.Collections.Generic;
using System.Xml.XPath;
using TMPro;
using UnityEngine;

public class Gird
{
    private int width;
    private int height;
    private int[,] girdArray;
    private float cellsize;
    private TextMesh[,] debugTestArray;

    public Gird(int width, int height,float cellsize)
    {
        this.width = width;
        this.height = height;
        this.cellsize = cellsize;


        girdArray = new int[width, height];
        debugTestArray = new TextMesh[width, height];

        for (int x = 0; x < girdArray.GetLength(0); x++)
        {
            for (int y = 0; y < girdArray.GetLength(1); y++)
            {
                Debug.Log(x + "," + y);
                CreateWorldText( null,girdArray[x,y].ToString(), GetWorldPosition(x, y)+new Vector3(cellsize,cellsize)*0.5f);
                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x + 1, y),Color.white,10f);
                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x, y + 1),Color.white,10f);

            }
            Debug.DrawLine(GetWorldPosition(width ,0 ), GetWorldPosition(width ,height ), Color.white, 10f);
            Debug.DrawLine(GetWorldPosition(0, height ), GetWorldPosition(width ,height ), Color.white, 10f);

            Setvalue(1, 1, 56);
        }


    }
    private Vector3 GetWorldPosition(int x,int y)
    {
        return new Vector3(x, y) * cellsize;

    }
    public void Setvalue(int x, int y, int value)
    {
        if (x >= 0 && y >= 0 && x < width && y < height)
        {
            girdArray[x, y] = value;
            debugTestArray[x, y].text = girdArray[x, y].ToString();
        }
    }

    private  TextMesh CreateWorldText(Transform parent,string text,Vector3 localPostion)
    {
        GameObject gameObject = new GameObject("World_Text", typeof(TextMesh));
        Transform transform = gameObject.transform;
        transform.SetParent(parent, false);
        transform.localPosition = localPostion;

        TextMesh textMesh = gameObject.GetComponent<TextMesh>();
        textMesh.anchor = TextAnchor.MiddleCenter;
        textMesh.alignment = TextAlignment.Center;
        textMesh.text = text;
        textMesh.color = Color.white;
        textMesh.fontSize = 10;
        textMesh.GetComponent<MeshRenderer>().sortingOrder = 99;

        return textMesh;
    }
        


}
