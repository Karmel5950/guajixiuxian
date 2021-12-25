using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public class TextViwer : MonoBehaviour
{
    public Text text;
    public Zhangsan zhangsan;
    public string textType;
    Assembly assembly;
    Type type;
    object obj;
    FieldInfo classField;
    // Start is called before the first frame update
    void Start()
    {
        assembly = System.Reflection.Assembly.GetExecutingAssembly();
        type = assembly.GetType("Zhangsan");
        obj = zhangsan;
        try
        {
            classField = type.GetField(textType);
        }
        catch (Exception ex)
        {
            Console.WriteLine("\t获取失败：" + ex.Message);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        try
        {
            text.text = classField.GetValue(obj).ToString();
        }
        catch (Exception ex)
        {

            Console.WriteLine("\t获取失败：" + ex.Message);
        }
        
        
    }
}
