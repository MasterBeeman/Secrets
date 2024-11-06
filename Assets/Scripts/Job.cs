using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum JobStatus
{
    NotStarted,
    Completed,
    Failed
}

public class Job : MonoBehaviour
{
    private string ClientName;
    private string JobDescription;
    private int Payment;
    private JobStatus JobStatus;
    private JobDetails Details;
}
