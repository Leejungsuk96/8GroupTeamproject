using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pill : MonoBehaviour
{
    private bool isInvincible = false;
    private float invincibilityDuration = 5f; // ���� ���� �ð� (��)
    public void bluePill(bool invincible)
    {
        if (invincible)
        {
            gameObject.layer = LayerMask.NameToLayer("Active");
        }
        else
        {
            gameObject.layer = LayerMask.NameToLayer("Deactive");
        }
    }
}
