using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;


public class MouseOverState : StateSwitchConditionBase, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private UnityEvent _onStateActivated;
    [SerializeField] private UnityEvent _onStateDisabled;

    private bool _mouseOver
    {
        set
        {
            if (value)
                OnStateActivated();
            else
                OnStateDisabled();
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _mouseOver = true;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _mouseOver = false;
    }

    protected override void OnStateActivated()
    {
        _onStateActivated.Invoke();
    }

    protected override void OnStateDisabled()
    {
        _onStateDisabled.Invoke();
    }
}
