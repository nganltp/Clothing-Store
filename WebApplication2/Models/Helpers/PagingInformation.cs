using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models.Helpers
{
    public class PagingInformation
    {
        public int pageIndex { get; set; }
        public int totalPages { get; set; }
        public int pageSize { get; set; }
        public PagingInformation()
        {
            this.pageIndex = 0;
            this.pageSize = 0;
            this.totalPages = 0;
        }
        public PagingInformation(int count, int pageIndex, int pageSize)
        {
            this.pageIndex = pageIndex;
            this.totalPages = (int)Math.Ceiling(count / (double)pageSize);
            this.pageSize=pageSize;

        }
        public bool hasPreviousPage { get { return pageIndex > 1; } }
        public bool hasNextPage { get { return pageIndex < totalPages; } }
    }
}
