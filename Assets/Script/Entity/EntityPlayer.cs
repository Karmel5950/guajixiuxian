using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityPlayer : Entity
{
    public static EntityPlayer instance = new EntityPlayer();
    GameObject gameObject = null;

    public override Entity addInstance() {

        return new EntityPlayer();

    }

    public override GameObject getGameObject()
    {
        if (gameObject == null)
        {
            gameObject = Resources.Load(ComponetResourcesPath.RESOURCES_PREFAB_PATH) as GameObject;
        }
        return gameObject;
    }
}
