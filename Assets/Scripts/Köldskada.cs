using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Köldskada : MonoBehaviour      //Emma
{
    private SpriteRenderer rend;
    private Color color;
    //Vector2 rayDir = new Vector2(5, 0);

    LayerMask mask;
   

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        color = rend.color;
        color.r = 1f;
        rend.color = color;

    }

    // Update is called once per frame
    void Update()
    {
        //Två raycasts, en kortare, för att man ska bli varmare snabbare ifall man
        //står närmare elden (två "hastigheter": normal, snabbare). 

        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right, 5);

        print(hit.point);

        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector2 (-10, 0);
        }


        if (hit.collider != null)
        {
            print("1.2.3");

            if (hit.collider.tag == "Warm")
            {
                //Starta timer för att bli varm
                color.r = 1f;
                rend.color = color;

            }
        }
        else
            //starta timer för att bli kall, ifall kall: varabel = något, ifall den varabeln är det startas timer för väldigt kall
            print("No");

        print("1245");

        if(Input.GetKey(KeyCode.A))
        {
            color.r = 0f;
            rend.color = color;
        }
    }
}
