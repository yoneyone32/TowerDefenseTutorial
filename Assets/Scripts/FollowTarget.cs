using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    [SerializeField] private Transform target; // �Ǐ]����Ώ�
    public Vector3 offset; // �I�t�Z�b�g�iWorld Space�̃I�t�Z�b�g�j
    private RectTransform rectTransform;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }
    private void Update()
    {
        if (target != null)
        {
            // World Position��Screen Position�ɕϊ�
            Vector2 screenPos = Camera.main.WorldToScreenPoint(target.position + offset);
            rectTransform.position = screenPos;
        }
    }
}
