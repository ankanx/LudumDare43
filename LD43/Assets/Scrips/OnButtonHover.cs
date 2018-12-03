using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
public class OnButtonHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{ 
    public void OnPointerEnter(PointerEventData eventData)
    {
        
        GetComponentInChildren<TextMeshProUGUI>().text = "NO";
        GetComponentInChildren<TextMeshProUGUI>().color = Color.red;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        GetComponentInChildren<TextMeshProUGUI>().text = "Exit";
        GetComponentInChildren<TextMeshProUGUI>().color = Color.white;
    }
}
