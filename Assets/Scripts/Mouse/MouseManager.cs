using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManager : MonoBehaviour
{
    public LayerMask targetLayer; // ������ ���̾ ����
    public GameManager manager;
    void Update()
    {
        if (Input.GetMouseButtonDown(1)) // ���콺 ���� ��ư Ŭ��
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            // ���콺 ��ġ�� Raycast�� ��� Ư�� ���̾ ����
            RaycastHit2D hit = Physics2D.Raycast(mousePosition, Vector2.zero, Mathf.Infinity, targetLayer);

            if (hit.collider != null)
            {
                GameObject scanObject = hit.collider.gameObject;
                // ������ ������Ʈ�� ��ġ�� �̸� ���
                Debug.Log("Clicked on: " + hit.collider.name +
                          " at position: " + hit.collider.transform.position +
                          " in layer: " + LayerMask.LayerToName(hit.collider.gameObject.layer));

                manager.Action(scanObject);


                // Ŭ���� ������Ʈ�� ���� �߰� ó���� ���⿡ �ۼ�
            }
            else
            {
                Debug.Log("No object detected in the specified layer at mouse position: " + mousePosition);
            }
        }
    }
}
