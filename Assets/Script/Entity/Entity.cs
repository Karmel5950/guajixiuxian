using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity
{
    public int entityID = -1;
    public List<IComponent> components;
    public Entity() {
       
    }

    public void setID(int id) {
        entityID = id;
    }

    public virtual Entity addInstance() {
        return new Entity();
    }

    public virtual GameObject getGameObject() {
        return null;
    }
}
