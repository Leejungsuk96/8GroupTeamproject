using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInvincibility : MonoBehaviour
{
    private bool isInvincible = false;
    // �˾�
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
