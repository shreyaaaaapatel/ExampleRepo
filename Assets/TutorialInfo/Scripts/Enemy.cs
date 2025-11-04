using UnityEngine;

public class Enemy : MonoBehaviour
{


    // Update is called once per frame
      void Update()
    {
        //transform.Translate(Vector3.down + Time.deltatime * 8f)
        transform.Translate(new Vector3(0, -1, 0) * Time.deltaTime * 8f);
        if(transform.position.y < -6.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
