using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//注册系统
//负责注册系统和实体
public class SystemRegister:SystemA
{
    private static List<SystemA> systemAs = new List<SystemA>();
    private static Dictionary<int, Entity> entitys =  new Dictionary<int, Entity>();
    private static SystemRegister _SystemInstance = null;

    public override void update()
    {
        
    }

    //单例模式获得实例
    public static SystemA getInstance()
    {
        if (_SystemInstance == null)
        {
            _SystemInstance = new SystemRegister();
        }
        return _SystemInstance;
    }
    //初始化方法，用于系统和实体的初始化注册
    public static void initialRegister(World world) {
        updateSystem(world);
        updateEntity(world);
    }
    //更新系统列表
    public static void updateSystem(World world) {
        world.systems = systemAs;
    }
    //更新实体列表
    public static void updateEntity(World world)
    {
        world.entitys = entitys;
    }
    //注册系统
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
    //注册实体
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
    //删除系统
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
    //删除实体
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
