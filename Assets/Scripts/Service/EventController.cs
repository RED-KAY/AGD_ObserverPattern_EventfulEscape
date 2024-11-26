using System;
using UnityEngine;

public class EventController
{
    public Action _BaseEvent;


    public void AddListener(Action listener) => _BaseEvent += listener;

    public void RemoveListener(Action listener) => _BaseEvent -= listener;


    public void InvokeEvent() => _BaseEvent?.Invoke();


}
