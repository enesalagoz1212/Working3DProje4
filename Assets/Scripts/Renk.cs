using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Renk : MonoBehaviour
{
    MeshRenderer renderer;
    public Material sari, kirmizi, yesil, mavi, mor;
    void Start()
    {
        renderer=GetComponent<MeshRenderer>();
       
    }

    void Update()
    {
        RenkVer();
    }
   void RenkVer()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int rastgele = Random.Range(1, 6);
            switch (rastgele)
            {
                case 1:
                    renderer.material = sari;
                    break;
                case 2:
                    renderer.material = kirmizi;
                    break;
                case 3:
                    renderer.material = yesil;
                    break;
                case 4:
                    renderer.material = mavi;
                    break;
                case 5:
                    renderer.material = mor;
                    break;
                
            }
        }
    }
}
