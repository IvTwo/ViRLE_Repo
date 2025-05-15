using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotDogActivityManager : ActivityManager
{
    [SerializeField] private GameObject robotDog;
    [SerializeField] private GameObject dogController;

    public void SpawnRobotDog() { if (!robotDog.activeInHierarchy) robotDog.SetActive(true); }

    public void SpawnDogController() { if (!dogController.activeInHierarchy) dogController.SetActive(true); }

    public override void CheckConditions() {
        switch (activityData.index) {
            case 1:
                SpawnDogController();
                break;

            case 2:
                SpawnRobotDog();
                break;
        }
    }
}
