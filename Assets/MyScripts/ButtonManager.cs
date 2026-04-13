using UnityEngine;

public class ButtonManager : MonoBehaviour
{
public delegate void ButtonPressed(int floor);
public static event ButtonPressed onButtonPressed;

public delegate void EmergencyButtonPressed();
public static event EmergencyButtonPressed onEmergencyButtonPressed;

public delegate void alarmButtonPressed();
public static event alarmButtonPressed onAlarmButtonPressed;

[SerializeField] AudioClip ElevatorAlarm;


public void AlarmButtonPressedHandler() {
    onAlarmButtonPressed?.Invoke();
}

    public void OnEnable()
    {
        onAlarmButtonPressed += AlarmButton;
    }
    public void OnDisable()
    {
        onAlarmButtonPressed -= AlarmButton;
    }
    public void AlarmButton()
    {
        AudioSource alarm = GetComponent<AudioSource>();
        alarm.clip = ElevatorAlarm;
        alarm.Play();
    }

public void ButtonPressedHandler(int floor) {
    onButtonPressed?.Invoke(floor);
}

public void EmergencyButtonPressedHandler() {
    onEmergencyButtonPressed?.Invoke();
}

}
