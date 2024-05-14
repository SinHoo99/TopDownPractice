using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    public LayerMask targetLayer; // 감지할 레이어를 설정
    public GameManager manager;
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) // 마우스 왼쪽 버튼 클릭
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // 마우스 위치에 Raycast를 쏘아 특정 레이어만 감지
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero, Mathf.Infinity, targetLayer);

            if (hit.collider != null)
            {
                GameObject scanObject = hit.collider.gameObject;
                // 감지된 오브젝트의 위치와 이름 출력
                Debug.Log("Clicked on: " + hit.collider.name +
                          " at position: " + hit.collider.transform.position +
                          " in layer: " + LayerMask.LayerToName(hit.collider.gameObject.layer));

                manager.Action(scanObject);


                // 클릭된 오브젝트에 대한 추가 처리를 여기에 작성
            }
            else
            {
                Debug.Log("No object detected in the specified layer at mouse position: " + mousePosition);
            }
        }
    }
}
