namespace AdManager.Model.Application.Inventory
{
    /// <summary>
    /// Full view model returned by all screen SPs.
    /// Joins: Inv.Screen + Inv.ScreenInfo + Core.Tenant (all INNER JOINs).
    /// Nullability matches DB schema exactly.
    /// </summary>
    public class MvScreen
    {
        // ── Inv.Screen ──────────────────────────────────────────────────
        public int Id { get; set; }          
        public int TenantId { get; set; }         
        public required string TenantName { get; set; }          
        public required string ScreenName { get; set; }           
        public required string ScreenType { get; set; }           
        public required string PlacementType { get; set; }           
        public decimal BasePrice { get; set; }           
        public required string Status { get; set; }           
        public int? CreatedBy { get; set; }           
        public DateTime CreatedAt { get; set; }           
        public bool IsDeleted { get; set; }           

        // ── Inv.ScreenInfo ───────────────────────────────────────────────
        public required string MacAddress { get; set; }            
        public required string Resolution { get; set; }          
        public required string Orientation { get; set; }          
        public decimal? ScreenSizeInch { get; set; }          
        public string? Manufacturer { get; set; }          
    }

    /// <summary>Lightweight item for dropdowns — Id + Name only.</summary>
    public class MvScreenDrop
    {
        public int Id { get; set; }
        public required string Name { get; set; }
    }

    /// <summary>
    /// Filter for the paginated grid (SpScreenSel).
    /// All fields optional — NULL means no filter applied.
    /// </summary>
    public class MvScreenGridFilter
    {
        public string? ScreenType { get; set; }
        public string? PlacementType { get; set; }
        public string? Status { get; set; }
        public int? TenantId { get; set; }
    }

    /// <summary>
    /// Filter for free-text search (SpScreenFilterSel).
    /// All fields optional — NULL means no filter applied.
    /// </summary>
    public class MvScreenSearchFilter
    {
        public string? ScreenType { get; set; }
        public string? Status { get; set; }
        public int? TenantId { get; set; }
        public string? SearchText { get; set; }
    }

    /// <summary>Payload for inserting a new Screen + ScreenInfo (SpScreenIns).</summary>
    public class MvPostScreen
    {
        public int TenantId { get; set; }           
        public required string ScreenName { get; set; }           
        public required string ScreenType { get; set; }           
        public required string PlacementType { get; set; }           
        public decimal BasePrice { get; set; }           
        public required string Status { get; set; }           
        public int? CreatedBy { get; set; }           
        public required MvScreenInfoIns ScreenInfo { get; set; }
    }

    public class MvScreenInfoIns
    {
        public required string MacAddress { get; set; }           
        public required string Resolution { get; set; }          
        public required string Orientation { get; set; }          
        public decimal? ScreenSizeInch { get; set; }          
        public string? Manufacturer { get; set; }          
    }

    /// <summary>Payload for updating an existing Screen + ScreenInfo (SpScreenUpd).</summary>
    public class MvPutScreen
    {
        public int Id { get; set; }          // PK, required for update
        public required string ScreenName { get; set; }           
        public required string ScreenType { get; set; }           
        public required string PlacementType { get; set; }           
        public decimal BasePrice { get; set; }           
        public required string Status { get; set; }           
        public required MvScreenInfoUpd ScreenInfo { get; set; }
    }

    public class MvScreenInfoUpd
    {
        public required string Resolution { get; set; }          
        public required string Orientation { get; set; }          
        public decimal? ScreenSizeInch { get; set; }          
        public string? Manufacturer { get; set; }          
    }

    /// <summary>Payload for soft-deleting a Screen (SpScreenDel).</summary>
    public class MvDeleteScreen
    {
        public int Id { get; set; }
        public int UpdatedBy { get; set; }
    }

    /// <summary>
    /// Upsert payload (SpScreenTsk).
    /// Id null = INSERT path, Id provided = UPDATE path.
    /// </summary>
    public class MvUpsertScreen
    {
        public int? Id { get; set; }          
        public int TenantId { get; set; }           
        public required string ScreenName { get; set; }           
        public required string ScreenType { get; set; }           
        public required string PlacementType { get; set; }           
        public decimal BasePrice { get; set; }           
        public required string Status { get; set; }           
        public int? CreatedBy { get; set; }           
        public required MvScreenInfoTsk ScreenInfo { get; set; }
    }

    public class MvScreenInfoTsk
    {
        public required string MacAddress { get; set; }            
        public required string Resolution { get; set; }          
        public required string Orientation { get; set; }          
        public decimal? ScreenSizeInch { get; set; }          
        public string? Manufacturer { get; set; }          
    }
}