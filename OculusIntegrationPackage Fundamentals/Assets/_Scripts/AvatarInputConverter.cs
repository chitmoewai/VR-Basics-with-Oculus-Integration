using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarInputConverter : MonoBehaviour
{

    //Avatar Transform
    public Transform mainAvatarTransform;
    public Transform avatarHead;
    public Transform avatarBody;

    public Transform avatarHand_Left;
    public Transform avatarHand_Right;

    //OculusTransform
    public Transform oculusHead;
    public Transform oculusHand_left;
    public Transform oculusHand_Right;

    public Vector3 positionOffset;

    private void Update()
    {
        mainAvatarTransform.position = Vector3.Lerp(mainAvatarTransform.position, oculusHead.position + positionOffset, 0.5f);
        avatarHead.rotation = Quaternion.Lerp(avatarHead.rotation, oculusHead.rotation, 0.5f);

        avatarBody.rotation = Quaternion.Lerp(avatarBody.rotation, Quaternion.Euler(new Vector3(0, avatarHead.rotation.eulerAngles.y, 0)), 0.05f);
        //hands
        avatarHand_Right.position = Vector3.Lerp(avatarHand_Right.position, oculusHand_left.position, 0.5f);
        avatarHand_Right.rotation = Quaternion.Lerp(avatarHand_Right.rotation, oculusHand_Right.rotation, 0.5f);

        avatarHand_Left.position = Vector3.Lerp(avatarHand_Left.position, oculusHand_left.position, 0.5f);
        avatarHand_Left.rotation = Quaternion.Lerp(avatarHand_Left.rotation, oculusHand_left.rotation, 0.5f);

    }

}
