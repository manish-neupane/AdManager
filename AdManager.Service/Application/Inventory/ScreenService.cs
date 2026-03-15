using AdManager.DataAccess;
using AdManager.Interface.Application.Inventory;
using AdManager.Model.Application.Inventory;
using AdManager.Model.Shared;
using Newtonsoft.Json;

namespace AdManager.Service.Application.Inventory
{
    public class ScreenService(IDataAccessService ds) : IScreenService
    {
        public async Task<MvGridConfig<MvScreen>?> GetScreenGrid(MvParamReqOption<MvScreenGridFilter> param)
        {
            try
            {
                string result = await ds.RetrievalProcedure("Inv.SpScreenSel", JsonConvert.SerializeObject(param));
                return JsonConvert.DeserializeObject<MvGridConfig<MvScreen>>(result);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<MvScreen>?> GetScreenList(MvScreenSearchFilter param)
        {
            try
            {
                string result = await ds.RetrievalProcedure("Inv.SpScreenFilterSel", JsonConvert.SerializeObject(param));
                return JsonConvert.DeserializeObject<List<MvScreen>>(result);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<MvScreenDrop>?> GetScreenDropdown()
        {
            try
            {
                string result = await ds.RetrievalProcedure("Inv.SpScreenDropSel", "{}");
                return JsonConvert.DeserializeObject<List<MvScreenDrop>>(result);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<MvScreen>?> PostScreen(MvPostScreen param)
        {
            try
            {
                string result = await ds.ActionProcedure("Inv.SpScreenIns", JsonConvert.SerializeObject(param));
                
               

                if (!result.TrimStart().StartsWith("["))
                {
                    var spError = JsonConvert.DeserializeObject<MvSpError>(result);
                    throw new InvalidOperationException(spError?.Message ?? "An error occurred");
                }
                return JsonConvert.DeserializeObject<List<MvScreen>>(result);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<MvScreen>?> PutScreen(MvPutScreen param)
        {
            try
            {
                string result = await ds.ActionProcedure("Inv.SpScreenUpd", JsonConvert.SerializeObject(param));

                if (!result.TrimStart().StartsWith("["))
                {
                    var spError = JsonConvert.DeserializeObject<MvSpError>(result);
                    throw new InvalidOperationException(spError?.Message ?? "An error occurred");
                }
                return JsonConvert.DeserializeObject<List<MvScreen>>(result);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<MvScreen?> DeleteScreen(MvDeleteScreen param)
        {
            try
            {
                string result = await ds.ActionProcedure("Inv.SpScreenDel", JsonConvert.SerializeObject(param));
                return JsonConvert.DeserializeObject<MvScreen>(result);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<MvScreen?> PostUpsertScreen(MvUpsertScreen param)
        {
            try
            {
                string result = await ds.ActionProcedure("Inv.SpScreenTsk", JsonConvert.SerializeObject(param));
                return JsonConvert.DeserializeObject<MvScreen>(result);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}