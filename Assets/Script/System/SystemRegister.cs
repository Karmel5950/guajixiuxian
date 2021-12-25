using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//ע��ϵͳ
//����ע��ϵͳ��ʵ��
public class SystemRegister:SystemA
{
    private static List<SystemA> systemAs = new List<SystemA>();
    private static Dictionary<int, Entity> entitys =  new Dictionary<int, Entity>();
    private static SystemRegister _SystemInstance = null;

    public override void update()
    {
        
    }

    //����ģʽ���ʵ��
    public static SystemA getInstance()
    {
        if (_SystemInstance == null)
        {
            _SystemInstance = new SystemRegister();
        }
        return _SystemInstance;
    }
    //��ʼ������������ϵͳ��ʵ��ĳ�ʼ��ע��
    public static void initialRegister(World world) {
        updateSystem(world);
        updateEntity(world);
    }
    //����ϵͳ�б�
    public static void updateSystem(World world) {
        world.systems = systemAs;
    }
    //����ʵ���б�
    public static void updateEntity(World world)
    {
        world.entitys = entitys;
    }
    //ע��ϵͳ
    public static bool systemRegist(SystemA systemA, World world) {
        foreach (SystemA item in systemAs)
        {
            if (item == systemA)
            {
                return false;
            }
        }
        systemAs.Add(systemA);
        updateSystem(world);
        return true;
    }
    //ע��ʵ��
    public static bool entityRegist(Entity entity, World world)
    {
        foreach (var item in entitys)
        {
            if (item.Key == entity.entityID)
            {
                return false;
            }
        }
        entitys.Add(entity.entityID,entity);
        updateEntity(world);
        return true;
    }
    //ɾ��ϵͳ
    public static bool systemDelet(SystemA systemA, World world)
    {
        foreach (SystemA item in systemAs)
        {
            if (item == systemA)
            {
                systemAs.Remove(systemA);
                updateSystem(world);
                return true;
            }
        }
        return false;
    }
    //ɾ��ʵ��
    public static bool entityDelet(Entity entity, World world)
    {
        foreach (var item in entitys)
        {
            if (item.Key == entity.entityID)
            {
                entitys.Remove(entity.entityID);
                updateEntity(world);
                return true;
            }
        }
        return false;
    }

}
