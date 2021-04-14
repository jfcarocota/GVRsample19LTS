using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
  [SerializeField]
  Color catchColor = Color.cyan;

  Renderer render;
  [SerializeField]
  MessageController textInteraction;
  [SerializeField]
  DialogItem dialogItem;

  void Awake()
  {
    render = GetComponent<Renderer>();
  }

  public void HandleColor() => render.material.color = catchColor;

  public void HandleTextInteraction() =>  textInteraction.gameObject?.SetActive(!textInteraction.gameObject.activeSelf);

  public void handleClick()
  {
    HandleColor();
    HandleTextInteraction();
    textInteraction.Message = dialogItem.Message;
  }
}
