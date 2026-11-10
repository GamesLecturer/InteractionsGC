using UnityEngine;

public class PlayerInspect : MonoBehaviour
{
    public float interactionDistance = 3f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            InspectObject();
        }
    }

    public void InspectObject()
    {
        RaycastHit hit;

        //This checks if the raycasts hit anything, and execute if it did
        if(Physics.Raycast(transform.position, transform.forward,
            out hit, interactionDistance))
        {
            Debug.Log("Looking at: " + hit.collider.gameObject.name);
        }
        else //It executes this section if it detects no objects.
        {
            Debug.Log("You missed everything");
        }
    }
}
