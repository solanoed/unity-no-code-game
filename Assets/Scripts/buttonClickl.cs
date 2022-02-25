using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class buttonClickl : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    // Start is called before the first frame update
    public Image Image;
    public Sprite DefaultSprite, PressedSprite;

    public void OnPointerDown(PointerEventData eventData){
        Image.sprite = PressedSprite;
    }
    public void OnPointerUp(PointerEventData eventData){
        Image.sprite = DefaultSprite;

    }
  

}
