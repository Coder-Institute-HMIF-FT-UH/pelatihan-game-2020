using UnityEngine;

public class RockScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Rock").transform.position = new Vector3(1,1,1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
