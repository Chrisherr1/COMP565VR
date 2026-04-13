using UnityEngine;
using UnityEngine.UI;

public class PlatformMoving : MonoBehaviour
{
    bool canMove;

    // elevator moves over a set duration of time
    [SerializeField] float duration = 2f; // seconds to complete the move
    [SerializeField] int startPoint;
    [SerializeField] Transform[] points;

    int targetFloor;
    Vector3 startPosition;
    float elapsedTime;

    private void OnEnable()
    {
        ButtonManager.onButtonPressed += StartMoving;
        ButtonManager.onEmergencyButtonPressed += StopMoving; // stop moving if emergency button is pressed
    }

    private void OnDisable()
    {
        ButtonManager.onButtonPressed -= StartMoving;
        ButtonManager.onEmergencyButtonPressed -= StopMoving;
    }

    // Button press just sets up the move — Update executes it
    private void StartMoving(int floor)
    {
        targetFloor = floor;
        startPosition = transform.position;
        elapsedTime = 0f;
        canMove = true;
    }

    private void StopMoving()
    {
        canMove = false;
    }

    void Update()
    {
        // if elevator not allowed to move exit script
        if (!canMove) return;

        // add time elapsed to total time
        elapsedTime += Time.deltaTime;
        // clamp t between 0 and 1 so lerp works
        float t = Mathf.Clamp01(elapsedTime / duration); // 0 → 1 over `duration` seconds

        // lerp position from start to target over calculated t
        transform.position = Vector3.Lerp(startPosition, points[targetFloor].position, t);

        // if time is now greater than 1
        if (t >= 1f)
        {
            // stop moving
            canMove = false;
        }
    }



    void Start()
    {
        transform.position = points[startPoint].position;
    }
}