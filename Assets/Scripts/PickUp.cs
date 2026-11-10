using UnityEngine;

public class PickUp : MonoBehaviour
{

    //Variables
    public GameManager gm;

    private void Start()
    {
        //This piece of code assigns the gamamanger without us having to use inspector
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Collected");
            Destroy(gameObject);

            gm.AddPoints();
            //Other is a reference to the collided object collider
        }
    }
}
