using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private GameManager gm;

    void OnCollisionEnter(Collision coll)
    {
        if(coll.gameObject.tag == "Bullet")
        {
            gm.SetScore(gm.GetScore() + 1);
            Destroy(gameObject, 0.1f);
        }
        if(coll.gameObject.tag == "Floor")
        {
            gm.SetMsg("GameOver");
        }
    }
    public void SetGameManager(GameManager gm)
    {
        this.gm = gm;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
