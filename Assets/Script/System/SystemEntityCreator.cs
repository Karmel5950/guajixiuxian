using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//ʵ������ϵͳ
//��������ʵ���ע��ʵ��
public class SystemEntityCreator : SystemA
{
    private static int id = 0;

    public override void update()
    {
        
    }
    //����ʵ��ID�ķ��������ɺ���Զ�ע��
    public static bool entityCreate(Entity entity ,World world) {
        Entity entity1 = entity.addInstance();
        entity1.setID(id);
        GameObject.Instantiate(entity1.getGameObject());
        entity1.getGameObject().SetActive(true);
        Debug.Log("������һ��ʵ��,IDΪ:" + id);
        id += 1;
        return SystemRegister.entityRegist(entity1, world);
    }

}
