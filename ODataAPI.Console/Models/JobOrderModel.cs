namespace ODataAPI.Console.Models;

public class JobOrderModel
{
    public string odatacontext { get; set; }
    public Value[] value { get; set; }
}

public class Value
{
    public string JobId { get; set; }
    public string Site { get; set; }
    public string Job { get; set; }
    public int Suffix { get; set; }
    public string Lot { get; set; }
    public string Warehouse { get; set; }
    public string Item { get; set; }
    public bool ReadyToComplete { get; set; }
    public string Status { get; set; }
    public float QuantityReleased { get; set; }
    public float QuantityCompleted { get; set; }
    public DateTime JobDate { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime ProjectedCompleteDate { get; set; }
    public bool Rework { get; set; }
    public string ReferenceType { get; set; }
    public object ReferenceNumber { get; set; }
    public int ReferenceLine { get; set; }
    public int ReferenceRelease { get; set; }
    public string Project { get; set; }
    public int Task { get; set; }
    public bool UnpostedJobTransactions { get; set; }
    public string ItemDesc { get; set; }
    public string Revision { get; set; }
    public float Scrapped { get; set; }
    public string PlannerCode { get; set; }
    public string ProjectDesc { get; set; }
    public string ParentJob { get; set; }
    public int ParentSuffix { get; set; }
    public string FinishJob { get; set; }
    public int FinishSuffix { get; set; }
    public float Expected { get; set; }
    public float QuantityOrdered { get; set; }
    public object OrderDate { get; set; }
    public object DueDate { get; set; }
    public object Customer { get; set; }
    public string CustomerName { get; set; }
    public string TaskDesc { get; set; }
    public bool ILCOutside { get; set; }
    public float TotalWIPAmount { get; set; }
    public string ProductCode { get; set; }
}
