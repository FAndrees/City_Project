
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime;
using System;
using UnityEngine.UIElements;
using System.Globalization;
using Valve.VR;
using Valve.VR.InteractionSystem;

public class Output : MonoBehaviour
{
    public SteamVR_Action_Vector2 m_MoveValue = null;
    public GameObject Camera = null;
    public GameObject Controller = null;
    public UnityEngine.UI.InputField InputField;
    private String Name;
    private List<string[]> rowData = new List<string[]>();
    private int counter;
    private int counter1;
    private int counter2;
    private int counter3;
    int Checkpoints_remaining;
    private void Awake()
    {
        DateTime localDate = DateTime.Now;

        Name = System.DateTime.Now.ToString("HH-mm-ss");
    }
    void Start()
    {
       
        Checkpoints_remaining = 11;
        GameObject[] Checkpoints = GameObject.FindGameObjectsWithTag("Checkpoint");
        Checkpoints_remaining = Checkpoints.Length;
        InputField.gameObject.SetActive(true);
        DateTime localDate = DateTime.Now;
        
        string[] rowDataTemp = new string[11];
        rowDataTemp[0] = "Timestamp";
        rowDataTemp[1] = "Checkpoint_Reached";
        rowDataTemp[2] = "Button_Void";
        rowDataTemp[3] = "X_Controller_Input";
        rowDataTemp[4] = "Y_Controller_Input";
        rowDataTemp[5] = "X_Head_Position";
        rowDataTemp[6] = "Y_Head_Position";
        rowDataTemp[7] = "Z_Head_Position";
        rowDataTemp[8] = "X_Head_Tilt";
        rowDataTemp[9] = "Y_Head_Tilt";
        rowDataTemp[10] = "Z_Head_Tilt";

        rowData.Add(rowDataTemp);

    }
   
       
        void Update()
    {
        if (InputField.interactable == false)
        { Save(); }
        if (Input.GetMouseButtonDown(1))
        {
            Application.Quit();
        }
        //if (Input.GetKeyDown(KeyCode.KeypadEnter))

        //{
       //     Save();
       // }

        if (Input.GetKeyDown(KeyCode.Keypad0))
        { counter2++;
        //    Save();
        }
       // if (m_MoveValue.axis.x != 0)
      //  { Save(); }
        GameObject[] Checkpoints = GameObject.FindGameObjectsWithTag("Checkpoint");
        if (Checkpoints.Length != Checkpoints_remaining)
        {
            counter++;
            Debug.Log(counter);
            Checkpoints_remaining = Checkpoints.Length;
           // Save();
            return;
        }
        

    }

      
    
    void Save()
    {
        string[] rowDataTemp = new string[11];
        rowDataTemp[0] = System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss:fffff");//Time UCT+1
        rowDataTemp[1] = counter.ToString(); //Checkpoint Hit
        rowDataTemp[2] = counter2.ToString(); //Void
        rowDataTemp[3] = m_MoveValue.axis.x.ToString();//Movement x Axis
        rowDataTemp[4] = m_MoveValue.axis.y.ToString();//Movement y Axis
        rowDataTemp[5] = Camera.transform.position.x.ToString();//x Position Head
        rowDataTemp[6] = Camera.transform.position.y.ToString();//y Position Head
        rowDataTemp[7] = Camera.transform.position.z.ToString();//z Position Head
        rowDataTemp[8] = Camera.transform.eulerAngles.x.ToString();//x Tilt Head
        rowDataTemp[9] = Camera.transform.eulerAngles.y.ToString();//y Tilt Head
        rowDataTemp[10] = Camera.transform.eulerAngles.z.ToString();//z Tilt Head


        rowData.Add(rowDataTemp);


        string[][] output = new string[rowData.Count][];

        for (int i = 0; i < output.Length; i++)
        {
            output[i] = rowData[i];
        }

        int length = output.GetLength(0);
        string delimiter = "/";

        StringBuilder sb = new StringBuilder();

        for (int index = 0; index < length; index++)
            sb.AppendLine(string.Join(delimiter, output[index]));


        string filePath = GetPath();

        StreamWriter outStream = System.IO.File.CreateText(filePath);
        outStream.WriteLine(sb);
        outStream.Close();

    }

    // Following method is used to retrive the relative path as device platform
    string GetPath()
    {
#if UNITY_EDITOR
       
        //return Application.dataPath + "/CSV_City_Nose/"  + DateTime.Now.ToLongDateString() + "_" + InputField.text.ToString() + ".csv";
        
        return "C:/Users/Josupeit/Desktop/CSV_City/" + DateTime.Now.ToLongDateString() + "_" +  Name + "_"+ InputField.text.ToString() + ".csv";

#else
        //return "C:/Users/Josupeit/Desktop/CSV_City/" + DateTime.Now.ToLongDateString() + "_" + InputField.text.ToString() + ".csv";
        //return Application.dataPath + "/CSV_City2/" + DateTime.Now.ToLongDateString() + "_" + InputField.text.ToString() + ".csv";
        return Application.dataPath + "/" + DateTime.Now.ToLongDateString() + "_" +  Name + "_" + InputField.text.ToString() + ".csv";
#endif
    }
}




