using System;
using System.Linq;

using Its.Onix.Core.Business;
using Its.Onix.Core.Databases;
using Its.Onix.Core.Commons.Model;

namespace Its.Onix.Erp.Businesses.Commons
{
    public abstract class GetListOperation : BusinessOperationBase
    {
        protected BaseDbContext context = null;
        protected QueryRequestParam queryParam = null;

        protected abstract IQueryable<BaseModel> Query();
        protected abstract int GetTotalRecord();

        private int GetTotalPage(int totalRec)
        {
            return 0;
        }

        public QueryResponseParam Apply(QueryRequestParam param)
        {            
            queryParam = param;
            context = GetDatabaseContext();                    

            QueryResponseParam qrp = new QueryResponseParam();
            int totalRec = GetTotalRecord();

            qrp.Results = Query();
            qrp.RecordCount = qrp.Results.Count();
            qrp.TotalRecord = totalRec;
            qrp.TotalPage = GetTotalPage(totalRec);

            return qrp;
        }
    }
}