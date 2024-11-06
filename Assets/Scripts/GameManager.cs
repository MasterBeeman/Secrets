using System;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class DailyRequest
{
    public List<RequestSO> Requests;
}

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private DateTime CurrentDate = new DateTime(1995, 6, 1);
    private int DayIndex = 0;

    private int Trust = 100;
    private int Coins = 50;

    private List<RequestSO> IncomingRequestSOs = new List<RequestSO>();
    private List<ContractSO> CurrentContracts = new List<ContractSO>();

    // List of daily requests, where each DailyRequest contains requests for a specific day
    [SerializeField] private List<DailyRequest> DailyRequests = new List<DailyRequest>();

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UIManager.Instance.UpdateDay(CurrentDate.Day);
        UIManager.Instance.SetNumberOfIncomingRequestsText(IncomingRequestSOs.Count);
        AddIncomingRequests();
    }

    public void FinishDay()
    {
        if (IncomingRequestSOs.Count > 0)
        {
            Debug.LogWarning("Need to check incoming requests");
            return;
        }

        // Process any contracts and deadlines

        AddIncomingRequests();

        // Increment day and update UI
        CurrentDate = CurrentDate.AddDays(1);
        DayIndex++;
        UIManager.Instance.UpdateDay(CurrentDate.Day);
    }

    public void AcceptRequest()
    {
        // Add accepted request to contracts and update UI
        UIManager.Instance.SetIncomingPanel(false);
    }

    public void CheckIncomingMessages()
    {
        if (IncomingRequestSOs.Count <= 0)
        {
            Debug.Log("No new requests");
            return;
        }

        UIManager.Instance.SetIncomingPanel(true);
    }

    private void AddIncomingRequests()
    {
        if (DayIndex <= DailyRequests.Count)
        {
            IncomingRequestSOs = new List<RequestSO>(DailyRequests[DayIndex].Requests);
            UIManager.Instance.SetNumberOfIncomingRequestsText(IncomingRequestSOs.Count);
        }
        else
        {
            Debug.LogWarning("No more requests available for the day.");
        }
    }
}
