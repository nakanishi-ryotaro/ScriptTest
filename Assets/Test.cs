using UnityEngine;
using System.Collections;

public class Boss
{
    private int mp = 53;
    public void Magic()
    {
        if (mp>=5)
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは"+mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない");
        }
    }

}

public class Test : MonoBehaviour
{

    void Start()
    {
        Boss lastboss = new Boss();
        for(int i = 0; i< 11; i++)
        {
            lastboss.Magic();
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}