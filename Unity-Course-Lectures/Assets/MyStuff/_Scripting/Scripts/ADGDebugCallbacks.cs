using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public bool LogAwakeMessage;
    public string WarningMessage;
    public string ErrorMessage;
    
    void Awake()
    {
        Debug.Log("AWAKE");
    }

    void OnEnable()
    {
        Debug.Log("Enable");
    }

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("START");

        if(LogAwakeMessage)
        {
            Debug.LogWarning(WarningMessage);
            Debug.LogError(ErrorMessage);
        }    
    }

    void FixedUpdate()
    {
        Debug.Log("FIXED UPDATE");
    }

    // Update is called once per frame  
    void Update()
    {
        Debug.Log("UPDATE");
    }

    void LateUpdate()
    {
        Debug.Log("LATE UPDATE");
    }

    void OnDisable()
    {
        Debug.Log("ON DISABLE");
    }

    void OnDestroy()
    {
        Debug.Log("DESTROY");
    }
}
