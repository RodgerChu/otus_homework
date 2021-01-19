using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class ClickedState : StateSwitchConditionBase, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
    [SerializeField] private UnityEvent _onStateActivated;
    [SerializeField] private UnityEvent _onStateDisabled;

    private bool _clicked
    {
        set
        {
            if (value)
                OnStateActivated();
            else
                OnStateDisabled();
        }
    }

    protected override void OnStateActivated()
    {
        _onStateActivated.Invoke();
    }

    protected override void OnStateDisabled()
    {
        _onStateDisabled.Invoke();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        _clicked = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _clicked = false;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _clicked = false;
    }
}
