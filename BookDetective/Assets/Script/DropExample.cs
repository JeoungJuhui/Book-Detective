using UnityEngine;
using UnityEngine.EventSystems;

public class DropExample : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        Debug.Log("Drop");
        // throw new System.NotImplementedException();
    }
}