using ShopQuanAo.Entities;

namespace ShopQuanAo.Areas.Admin.Controllers
{
    internal class PagesList<T>
    {
        private IOrderedQueryable<Customer> lsCustomers;
        private int pageNumber;
        private int pageSize;

        public PagesList(IOrderedQueryable<Customer> lsCustomers, int pageNumber, int pageSize)
        {
            this.lsCustomers = lsCustomers;
            this.pageNumber = pageNumber;
            this.pageSize = pageSize;
        }
    }
}