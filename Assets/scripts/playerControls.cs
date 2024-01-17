using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour
{
    [SerializeField] float xOffsetVelocity;
    [SerializeField] float yOffsetVelocity;
    [SerializeField] float xMoveRange;
    [SerializeField] float yMoveRange;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update(){
        moveHorizontal();
        moveVertical();
    }

    void moveHorizontal() {
        float horizontalMove = Input.GetAxis("Horizontal");
        float newXpos = transform.localPosition.x + ((xOffsetVelocity * horizontalMove) * Time.deltaTime);
        float clampedXPos = Mathf.Clamp(newXpos, -xMoveRange, xMoveRange);

        transform.localPosition = new Vector3(clampedXPos, transform.localPosition.y,transform.localPosition.z);
        
    }
    void moveVertical() {
        float verticalMove = Input.GetAxis("Vertical");
        float newYpos = transform.localPosition.y + ((yOffsetVelocity * verticalMove) * Time.deltaTime);
        float clampedYPos = Mathf.Clamp(newYpos, -yMoveRange, yMoveRange);

        transform.localPosition = new Vector3(transform.localPosition.x, clampedYPos, transform.localPosition.z);
    }
}
