using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance { get; private set; }

    [Header("Main Text")]
    [SerializeField] private TextMeshProUGUI DayText;

    [Header("Buttons")]
    [SerializeField] private Button MenuButton;
    [SerializeField] private Button RequestsButton;
    [SerializeField] private Button UpgradeButton;
    [SerializeField] private Button FinishDayButton;

    [Header("Options")]
    [SerializeField] private Transform OptionsPanelTransform;

    [Header("Requests")]
    [SerializeField] private Transform RequestPanelTransform;
    [SerializeField] private TextMeshProUGUI RequestBody;
    [SerializeField] private TextMeshProUGUI OfferingBody;
    [SerializeField] private Button CloseButton;

    [Header("Tabs")]
    [SerializeField] private Button OverallTab;
    [SerializeField] private Button SurveillanceTab;
    [SerializeField] private Button InvestigationTab;
    [SerializeField] private Button BreakInTab;
    [SerializeField] private Button HackingTab;
    [SerializeField] private Button TappingTab;
    [SerializeField] private Button VerdictTab;

    private Transform selectedTab;

    [Header("Pages")]
    [SerializeField] private Transform OverallPage;
    [SerializeField] private Transform SurveillancePage;
    [SerializeField] private Transform InvestigationPage;
    [SerializeField] private Transform BreakInPage;
    [SerializeField] private Transform HackingPage;
    [SerializeField] private Transform TappingPage;
    [SerializeField] private Transform VerdictPage;

    [Header("Upgrades")]
    [SerializeField] private Transform UpgradePanelTransform;

    [Header("Incoming")]
    [SerializeField] private Transform IncomingPanelTransform;
    [SerializeField] private TextMeshProUGUI NumberOfIncoming;


    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        // Having everything inactive when starting up the game
        RequestPanelTransform.gameObject.SetActive(false);
        UpgradePanelTransform.gameObject.SetActive(false);
        OptionsPanelTransform.gameObject.SetActive(false);
        IncomingPanelTransform.gameObject.SetActive(false);
    }

    public void SetDisplayOptionsPanel(bool isActive)
    {
        OptionsPanelTransform.gameObject.SetActive(isActive);
    }

    public void SetDisplayRequestPanel(bool isActive)
    {
        RequestPanelTransform.gameObject.SetActive(isActive);
    }

    public void SetDisplayUpgradePanel(bool isActive)
    {
        UpgradePanelTransform.gameObject.SetActive(isActive);
    }

    public void SetTab(Transform TabTransform)
    {
        if (selectedTab == null || TabTransform != selectedTab)
        {
            SoundManager.Instance.PlayTabSfx();
            selectedTab = TabTransform;
        }

        OverallPage.gameObject.SetActive(false);
        SurveillancePage.gameObject.SetActive(false);
        InvestigationPage.gameObject.SetActive(false);
        BreakInPage.gameObject.SetActive(false);
        HackingPage.gameObject.SetActive(false);
        TappingPage.gameObject.SetActive(false);
        VerdictPage.gameObject.SetActive(false);

        TabTransform.gameObject.SetActive(true);

        
    }

    public void UpdateDay(int day)
    {
        DayText.text = "Day " + day.ToString();
    }

    public void SetIncomingPanel(bool isActive)
    {
        IncomingPanelTransform.gameObject.SetActive(isActive);
    }

    public void SetNumberOfIncomingRequestsText(int numberOfIncomingRequests)
    {
        NumberOfIncoming.text = numberOfIncomingRequests.ToString();
    }
}
