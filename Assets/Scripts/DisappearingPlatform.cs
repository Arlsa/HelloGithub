using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisappearingPlatform : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator OnCollsionEnter (Collision coll)
    {
        yield return new WaitForSeconds(2);
        Destroy(gameObject);
    }

}
