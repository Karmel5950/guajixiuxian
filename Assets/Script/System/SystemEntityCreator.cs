using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//实体生成系统
//负责生成实体和注册实体
public class SystemEntityCreator : SystemA
{
    private static int id = 0;

    public override void update()
    {
        
    }
    //生成实体ID的方法，生成后会自动注册
    public static bool entityCreate(Entity entity ,World world) {
        Entity entity1 = entity.addInstance();
        entity1.setID(id);
        GameObject.Instantiate(entity1.getGameObject());
        entity1.getGameObject().SetActive(true);
        Debug.Log("生成了一个实体,ID为:" + id);
        id += 1;
        return SystemRegister.entityRegist(entity1, world);
    }

}
