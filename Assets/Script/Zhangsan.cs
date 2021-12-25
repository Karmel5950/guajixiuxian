using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zhangsan : MonoBehaviour
{
    public string name;
    public string age;
    int ageNow;
    int ageMax;
    public string levelName;
    public int level;
    public double ling;
    public double lingMax;
    public double addLingSpeed;
    public bool isXiuLian;
    
    // Start is called before the first frame update
    void Start()
    {
        name = "张三";
        ageNow = 18;
        ageMax = 80;
        age = ageNow + "/" + ageMax;
        levelName = "练气期";
        level = 1;
        ling = 0;
        updateLingMax();
        updateAddLingSpeed();
        isXiuLian = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (isXiuLian)
        {
            xiulian();
        }
        
    }

    void updateLingMax() 
    {
        lingMax = level * 100;
    }

    void updateAddLingSpeed()
    {

        addLingSpeed = level * 5;


    }

    void xiulian() {
        if (ling >= lingMax)
        {
            ling = 0;
            updateLingMax();
            updateAddLingSpeed();
        }
        else
        {
            ling = ling + 1 * addLingSpeed * Time.deltaTime;
        }
    }

}
