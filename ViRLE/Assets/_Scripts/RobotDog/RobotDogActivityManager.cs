using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotDogActivityManager : ActivityManager
{
    [SerializeField] private DogController robotDog;    // robot dog prefab
    [SerializeField] private GameObject dogController;
    [SerializeField] private GameObject gameMarker;
    [SerializeField] private LineRenderer guideLine;    // drag GuideLine under robot dog prefab

    [SerializeField] private List<Transform> riskSites;   // drag parent empty that holds each risk area
    private bool gameMarkersActive = false;

    void FixedUpdate() {
        UpdateLineRenderer();
    }

    public override void CheckConditions() {
        switch (activityData.index) {
            case 1:
                SpawnDogController();
                break;

            case 2:
                SpawnRobotDog();
                break;

            case 3:
                SpawnGameMarkers();
                SetLineRenderer();
                break;
        }
    }

    private void SpawnRobotDog() { if (!robotDog.gameObject.activeInHierarchy) robotDog.gameObject.SetActive(true); }

    private void SpawnDogController() { if (!dogController.activeInHierarchy) dogController.SetActive(true); }

    private void SpawnGameMarkers() {
        if (gameMarkersActive) { return; }
        foreach (Transform t in riskSites) {
            Instantiate(gameMarker, t.position + new Vector3(0f, 10f, 0f), Quaternion.identity);
        }
    }

    private void SetLineRenderer() {
        guideLine.gameObject.SetActive(true);
        guideLine.startWidth = 0.8f;
        guideLine.endWidth = 1.0f;
    } 

    /// <summary>
    /// Set Line renderer position to nearest hazard site as the robot dog moves
    /// </summary>
    private void UpdateLineRenderer() {
        if (!guideLine.gameObject.activeInHierarchy) { return; }

        guideLine.SetPosition(0, robotDog.gameObject.transform.position);

        // TODO: find nearest activity
        guideLine.SetPosition(1, riskSites[0].position);
    }
}
