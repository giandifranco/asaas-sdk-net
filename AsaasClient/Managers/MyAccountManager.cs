﻿using AsaasClient.Core;
using AsaasClient.Core.Response;
using AsaasClient.Models.MyAccount;
using System.Threading.Tasks;

namespace AsaasClient.Managers
{
    public class MyAccountManager : BaseManager
    {
        private const string MY_ACCOUNT_URL = "/myAccount";
        private const string PAYMENT_CHECKOUT_CONFIG_URL = MY_ACCOUNT_URL + "/paymentCheckoutConfig";

        public MyAccountManager(ApiSettings settings) : base(settings) { }

        public async Task<ResponseObject<MyAccount>> Find()
        {
            var responseObject = await GetAsync<MyAccount>(MY_ACCOUNT_URL);

            return responseObject;
        }

        public async Task<ResponseObject<PaymentCheckoutConfig>> CreatePaymentCheckoutConfig(CreatePaymentCheckoutConfigRequest requestObj)
        {
            var responseObject = await PostMultipartFormDataContentAsync<PaymentCheckoutConfig>(PAYMENT_CHECKOUT_CONFIG_URL, requestObj);

            return responseObject;
        }

        public async Task<ResponseObject<PaymentCheckoutConfig>> FindPaymentCheckoutConfig()
        {
            var responseObject = await GetAsync<PaymentCheckoutConfig>(PAYMENT_CHECKOUT_CONFIG_URL);

            return responseObject;
        }
    }
}