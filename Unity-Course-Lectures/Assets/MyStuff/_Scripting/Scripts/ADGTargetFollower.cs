using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADGTargetFollower : MonoBehaviour
{
    public GameObject Target;
    public float SpeedRotation = 1.0f;
    public float SpeedMovement = 1.0f;
    private bool targetFlag = true;
    // Start is called before the first frame update
    void Start()
    {
        if(Target == null)
        {
            ADGSimpleTarget st = GameObject.FindObjectOfType<ADGSimpleTarget>();

            if(st != null)
                Target = st.gameObject;
            else 
            {
                targetFlag = false;
                Debug.LogError("GameObject not found");
            }     
        }

        if(targetFlag)
            Debug.Log("Target found");
    }

    // Update is called once per frame
    void Update()
    {
        if(!targetFlag)
            return;

        Vector3 direction = Target.transform.position - transform.position;
        direction.y = 0;
        direction.Normalize();

        //rotation update
        float stepRotation = SpeedRotation * Time.deltaTime;
        Vector3 newforward = Vector3.RotateTowards(transform.forward, direction, stepRotation, 0.0f);
        transform.rotation = Quaternion.LookRotation(newforward, transform.up);

        //position update
        transform.Translate(Vector3.forward * SpeedMovement * Time.deltaTime);
    }
}
