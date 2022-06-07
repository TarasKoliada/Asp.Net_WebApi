using RestaurantApplication.BusinessLogic.Repositories.Implementation;
using RestaurantApplication.BusinessLogic.Repositories.Interfaces;
using RestaurantApplication.Domain.Models;

namespace RestaurantApplication.BusinessLogic.Repositories
{
    public class UoW : IUnitOfWork
    {
        private readonly RestaurantDatabaseContext _context;

        /*private CustomerRepository _customerRepo;
        private OrderRepository _orderRepo;
        private SiteRepository _siteRepo;
        private EmployeeRepository _employeeRepo;
        private PaymentRepository _paymentRepo;
        private RatingRepository _ratingRepo;
        private AdminRepository _adminRepo;*/

        public IGenericRepository<Customer> Customers { get; }

        public OrderRepository Orders => throw new System.NotImplementedException();

        public SiteRepository Sites => throw new System.NotImplementedException();

        public EmployeeRepository Employees => throw new System.NotImplementedException();

        public PaymentRepository Payments => throw new System.NotImplementedException();

        public RatingRepository Ratings => throw new System.NotImplementedException();

        public AdminRepository Admins => throw new System.NotImplementedException();
        public UoW(RestaurantDatabaseContext context, IGenericRepository<Customer> customers)
        {
            _context = context;
            Customers = customers;
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        /*public CustomerRepository Customers
        {
            get
            {
                if (_customerRepo == null)
                    _customerRepo = new CustomerRepository(_context);

                return _customerRepo;
            }
        }

        public OrderRepository Orders
        {
            get
            {
                if (_orderRepo == null)
                    _orderRepo = new OrderRepository(_context);

                return _orderRepo;
            }
        }

        public SiteRepository Sites
        {
            get
            {
                if (_siteRepo == null)
                    _siteRepo = new SiteRepository(_context);

                return _siteRepo;
            }
        }

        public EmployeeRepository Employees
        {
            get
            {
                if (_employeeRepo == null)
                    _employeeRepo = new EmployeeRepository(_context);

                return _employeeRepo;
            }
        }

        public PaymentRepository Payments
        {
            get
            {
                if (_paymentRepo == null)
                    _paymentRepo = new PaymentRepository(_context);

                return _paymentRepo;
            }
        }

        public RatingRepository Ratings
        {
            get
            {
                if (_ratingRepo == null)
                    _ratingRepo = new RatingRepository(_context);

                return _ratingRepo;
            }
        }

        public AdminRepository Admins
        {
            get
            {
                if (_adminRepo == null)
                    _adminRepo = new AdminRepository(_context);

                return _adminRepo;
            }
        }*/
    }
}
