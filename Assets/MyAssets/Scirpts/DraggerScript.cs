using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(EventTrigger))]
public class DraggerScript : MonoBehaviour
{
    private Rigidbody rb;
    private EventTrigger _trigger;
    void Start()
    {
        _trigger = GetComponent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerDown;
        entry.callback.AddListener((data)=>OnClick());
        _trigger.triggers.Add(entry);
        
        
        
        EventTrigger.Entry entry2 = new EventTrigger.Entry();
        entry2.eventID = EventTriggerType.PointerUp;
        entry2.callback.AddListener((data)=>OnExit());
        _trigger.triggers.Add(entry2);
        
        
        rb = GetComponent<Rigidbody>();
        GvrEventExecutor eventExecutor = GvrPointerInputModule.FindEventExecutor();
        eventExecutor.OnPointerClick += OnItemInterract;
    }

    void OnItemInterract(GameObject target, PointerEventData eventData)
    {
        Debug.Log("Item taked");   
    }

    public void OnClick()
    {
        transform.parent = Camera.main.transform;
        rb.isKinematic = true;
    }

    public void OnExit()
    {
        rb.isKinematic = false;
        transform.parent = null;
    }
}
