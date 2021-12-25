using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
    public List<SystemA> systems;                   //所有System
    public Dictionary<int, Entity> entitys;      //所有Entity，Int32是Entity.ID
    public static World mainWorld = null;
    void Start()
    {
        systems = new List<SystemA>();
        entitys = new Dictionary<int, Entity>();
        mainWorld = this;
        SystemRegister.initialRegister(mainWorld);
        SystemEntityCreator.entityCreate(EntityPlayer.instance, mainWorld);

    }

    void Update()
    {
        foreach (SystemA sys in systems) {
            sys.update();
        }
            
    }
}
