using UnityEngine;

public class RockScript : MonoBehaviour
{
    // Deklarasi variabel
    private BoxCollider rockCollider;
    
    // Start is called before the first frame update
    void Start()
    {
        rockCollider = GetComponent<BoxCollider>(); // Get component
        rockCollider.size = new Vector3(5,5,5); // Ubah size collider 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
