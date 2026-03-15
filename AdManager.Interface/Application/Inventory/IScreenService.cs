using AdManager.Model.Application.Inventory;
using AdManager.Model.Shared;

namespace AdManager.Interface.Application.Inventory
{
    public interface IScreenService
    {
        /// <summary>Paginated grid with optional filters.</summary>
        Task<MvGridConfig<MvScreen>?> GetScreenGrid(MvParamReqOption<MvScreenGridFilter> param);

        /// <summary>Filtered list with optional scalar filters and free-text search.</summary>
        Task<List<MvScreen>?> GetScreenList(MvScreenSearchFilter param);

        /// <summary>Active screens as Id + Name for dropdowns.</summary>
        Task<List<MvScreenDrop>?> GetScreenDropdown();

        /// <summary>Insert new Screen + ScreenInfo. Rejects duplicate MAC address.</summary>
        Task<List<MvScreen>?> PostScreen(MvPostScreen param);

        /// <summary>Update existing Screen + ScreenInfo by Id.</summary>
        Task<List<MvScreen>?> PutScreen(MvPutScreen param);

        /// <summary>Soft-delete a Screen by Id.</summary>
        Task<MvScreen?> DeleteScreen(MvDeleteScreen param);

        /// <summary>Upsert — insert if Id is null, update if Id is provided.</summary>
        Task<MvScreen?> PostUpsertScreen(MvUpsertScreen param);
    }
}
