using UnityEngine;

public class EventService
{
    public static EventService _Instance;
    
    public static EventService Instance {
        get {
            if (_Instance == null) { 
                _Instance = new EventService();
            }
            return _Instance; 
        }
    }


    public EventController OnLightSwitchToggled { get; private set; }

    public EventService()
    {
        OnLightSwitchToggled = new EventController();
    }

}
