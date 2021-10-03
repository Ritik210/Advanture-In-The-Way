using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DandD : MonoBehaviour
{
    public bool isDraggable = true;
    public bool isDregged = false;

    [SerializeField] Transform parent;
    
    // Update is called once per frame
    void Update()
    {
        if (isDregged)
        {
            transform.position = (Vector2)Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
        if ((transform.position.x >= -1.0f && transform.position.x <= 1.0f) && transform.position.y <= -1.5f) 
        {
            transform.position = new Vector2(0.09f, -2.7f);
            transform.rotation = Quaternion.identity;
          //  StartCoroutine(Block());


        }
        if ((transform.position.x >= 17f && transform.position.x <= 19f) && transform.position.y <= -1.5f)
        {
            transform.position = new Vector2(18.5f, -2.6f);
            transform.rotation = Quaternion.identity;
            //   StartCoroutine(Block());
        }
       if ((transform.position.x >= 36f && transform.position.x <= 37f) && transform.position.y <= -1.5f)
        {
            transform.position = new Vector2(36.3f, -2.2f);
            transform.rotation = Quaternion.identity;
            // StartCoroutine(Block());
        }
        if ((transform.position.x >= 67.5f && transform.position.x <= 68.7f) && transform.position.y <= -2.5f)
        {
            transform.position = new Vector2(68.699f, -3.27f);
           // transform.rotation = Quaternion.identity;
            // StartCoroutine(Block());
        }
        if ((transform.position.x >= 117.5f && transform.position.x <= 119f) && transform.position.y <= -3.3f)
        {
            transform.position = new Vector2(118.01f, -3.72f);
            transform.rotation = Quaternion.identity;
            // StartCoroutine(Block());
        }


    }
   /* IEnumerator Block()
    {
       yield return new WaitForSeconds(2f);
        Destroy(this.gameObject);
    }*/
    private void OnMouseOver()
    {
        if (isDraggable && Input.GetMouseButtonDown(0))
        {
            isDregged = true;
            gameObject.transform.parent = parent;
         //   transform.rotation = Quaternion.identity;
        }
      /*  if ((transform.position.x >= -1.0f  transform.position.x <= 1.0f) && transform.position.y <= -1.5f)
        {
            transform.position = new Vector2(0.09f, -2.6f);

        }*/



    }
    private void OnMouseUp()
    {
        isDregged = false;
       
    }


}
