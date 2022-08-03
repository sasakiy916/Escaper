using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Door : MonoBehaviour, IPointerClickHandler
{
    bool isOpen;
    public void OnPointerClick(PointerEventData eventData)
    {
        if (!isOpen)
        {
            transform.Rotate(new Vector3(0, -120, 0));
            isOpen = true;
        }
        else
        {
            transform.Rotate(new Vector3(0, 120, 0));
            isOpen = false;
        }

    }
}
