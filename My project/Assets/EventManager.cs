using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public static EventManager _instance;

    public static EventManager Instance
    {
        get
        {
            if (_instance == null)
                _instance = FindObjectOfType<EventManager>();
            if (_instance == null)
            {
                var go = new GameObject(nameof(EventManager));
                _instance = go.AddComponent<EventManager>();
            }

            return _instance;
        }

    }

    private Dictionary<string, Action<object>> _eventDir;

    private void Awake()
    {
        _eventDir = new Dictionary<string, Action<object>>();
    }

    public void Subcribe(string eventname, Action<object> action)
    {
        if(!_eventDir.ContainsKey(eventname))
            _eventDir.Add(eventname,action);
        else
        {
            _eventDir[eventname] += action;
        }
    }

    public void Emit(string eventname, object param = null)
    {
        if (_eventDir.ContainsKey(eventname))
        {
            _eventDir[eventname].Invoke(param);
        }
        else
        {
            Debug.LogError("해당 이벤트가 없습니다.");
        }
    }
}
