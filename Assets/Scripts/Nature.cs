using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// THIS CLASS MUST BE PUT ON NATURE OBJECT THAT CAN REACT TO ELEMENTS
public class Nature : MonoBehaviour
{
    public SystemicMaterial[] owningMaterials = null;
    public ElementSize size;

    private List<SystemicElement> currentActingElements = new List<SystemicElement>();

    public MaterialReaction[] reactions = null;

    public void ReactToElement(SystemicElement type, ElementSize size)
    {
        for (int i = 0; i < reactions.Length; i++)
        {
            if(reactions[i].theElement == type && 
                ((reactions[i].theSize != ElementSize.NONE && (int)size >= (int)reactions[i].theSize) ||
                reactions[i].theSize == ElementSize.NONE)
            )
                reactions[i].actions.Invoke();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        Element elem = other.GetComponentInParent<Element>();
        if (elem != null)
        {
            ReactToElement(elem.elementType, elem.elementSize);
        }
    }

    public void AddActingElement(SystemicElement elem)
    {
        if (!currentActingElements.Contains(elem))
            currentActingElements.Add(elem);
    }

    public void RemoveActingElement(SystemicElement elem)
    {
        if (currentActingElements.Contains(elem))
            currentActingElements.Remove(elem);
    }
}
