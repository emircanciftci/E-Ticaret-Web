using GiyimETicaret.BLL.Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiyimETicaret.BLL.Repository.Service
{
    public class EntityService
    {
        public EntityService()
        {
            _brandsService = new BrandsRepository();
            _categoriesService = new CategoriesRepository();
            _colorService = new ColorRepository();
            _customerUsersService = new CustomerUsersRepository();
            _orderItemsService = new OrderItemsRepository();
            _ordersService = new OrdersRepository();
            _paymentsService = new PaymentsRepository();
            _productsService = new ProductsRepository();
            _sizeService = new SizeRepository();
            _productImagesService = new ProductImagesRepository();
            _discountsService = new DiscountsRepository();
        }
        private BrandsRepository _brandsService;
        public BrandsRepository BrandsService
        {
            get { return _brandsService; }
            set { _brandsService = value; }
        }
        private CategoriesRepository _categoriesService;

        public CategoriesRepository CategoriesService
        {
            get { return _categoriesService; }
            set { _categoriesService = value; }
        }
        private ColorRepository _colorService;

        public ColorRepository ColorService
        {
            get { return _colorService; }
            set { _colorService = value; }
        }
        private CustomerUsersRepository _customerUsersService;

        public CustomerUsersRepository CustomerUsersService
        {
            get { return _customerUsersService; }
            set { _customerUsersService = value; }
        }
        private OrderItemsRepository _orderItemsService;

        public OrderItemsRepository OrderItemsService
        {
            get { return _orderItemsService; }
            set { _orderItemsService = value; }
        }
        private OrdersRepository _ordersService;

        public OrdersRepository OrdersService
        {
            get { return _ordersService; }
            set { _ordersService = value; }
        }
        private PaymentsRepository _paymentsService;

        public PaymentsRepository PaymentsService
        {
            get { return _paymentsService; }
            set { _paymentsService = value; }
        }
        private ProductsRepository _productsService;

        public ProductsRepository ProductsService
        {
            get { return _productsService; }
            set { _productsService = value; }
        }
        private SizeRepository _sizeService;

        public SizeRepository SizeService
        {
            get { return _sizeService; }
            set { _sizeService = value; }
        }
        private ProductImagesRepository _productImagesService;

        public ProductImagesRepository ProductImagesService
        {
            get { return _productImagesService; }
            set { _productImagesService = value; }
        }
        private DiscountsRepository _discountsService;

        public DiscountsRepository DiscountsService
        {
            get { return _discountsService; }
            set { _discountsService = value; }
        }








    }
}
